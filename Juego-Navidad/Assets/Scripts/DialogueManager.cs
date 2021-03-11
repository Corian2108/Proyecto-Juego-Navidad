using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public Dialogue dialogue;

    Queue<string> sentences;

    public GameObject dialoguePanel;
    public TextMeshProUGUI displayText;

    string activeSentence;
    public float typingSpeed;

    //buttons
    
    public GameObject botonContinuar;

    

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        botonContinuar.SetActive(false);
        
    }

    void StartDialogue()
    {
        
        sentences.Clear();
        foreach (string sentence in dialogue.sentenceList)
        {
            sentences.Enqueue(sentence);
            
        }

        DisplayNextSentence();
    }

   public void DisplayNextSentence()
    {
        
        if (sentences.Count <= 0)
        {
            displayText.text = activeSentence;
            
            return;
        }

        activeSentence = sentences.Dequeue();
        displayText.text = activeSentence;
        botonContinuar.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(TypeTheSentence(activeSentence));
    }

    IEnumerator TypeTheSentence(string sentence)
    {
        displayText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            displayText.text += letter;
            
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            dialoguePanel.SetActive(true);
            botonContinuar.SetActive(true);
            StartDialogue();
        }
    }


    private void OntriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
          if (botonContinuar && displayText.text==activeSentence)
                {
                    DisplayNextSentence();
                }
            
        }
    }

    public void botonCerrar()
    {
        dialoguePanel.SetActive(false);
        botonContinuar.SetActive(false);
    }
    private void OnTriggerExit2D(Collider2D obj)
    {
        if (obj.CompareTag("Player"))
        {
            dialoguePanel.SetActive(false);
            botonContinuar.SetActive(true);
            
        }
    }
}
