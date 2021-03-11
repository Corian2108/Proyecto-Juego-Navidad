using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsPool : MonoBehaviour
{
    public int buttonsPoolSize = 5;
    public GameObject butonsPrefab;
    public float buttonXMin = -16;
    public float buttonXMax = 16;
    private float spawnYPosition = 8.5f;
    private GameObject[] buttons;

    private Vector2 buttonsSpawn = new Vector2 (0,-15);
    private float timeSinceLastSpawned;
    public float spawnRate;
    private int currentButton;
    public float minimumSpawn = 1.5f;

    void Start()
    {
        buttons = new GameObject[buttonsPoolSize];
        for (int i = 0; i < buttonsPoolSize; i++)
        {
            buttons[i] = Instantiate(butonsPrefab, buttonsSpawn, Quaternion.identity);
        }
    }

    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if ( timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnXposition = Random.Range(buttonXMin, buttonXMax);
            buttons[currentButton].transform.position = new Vector2(spawnXposition, spawnYPosition);
            buttons[currentButton].GetComponent<ButtonPrefab>().clickable = false;
            buttons[currentButton].GetComponent<ButtonPrefab>().scored = false;
            buttons[currentButton].GetComponent<Renderer>().enabled = true;
            currentButton++;
            if(currentButton == buttonsPoolSize)
            {
                currentButton = 0;
            }
        }
    }
}
