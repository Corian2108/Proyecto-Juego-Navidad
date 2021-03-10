<<<<<<< HEAD
﻿using UnityEngine;

public class DEMO_SceneNavigation : MonoBehaviour {

    [SerializeField]
    private GameObject graphicsManager;
    [SerializeField]
    private GameObject soundManager;

    // Use this for initialization
    void Start () {

    }

    public void ChangeWindows(string nameBt) {
        soundManager.GetComponent<DEMO_SoundManager>().PlayClickSound();
        switch (nameBt) {
            case "ViewUpdateBt":
                graphicsManager.GetComponent<DEMO_GraphicsManager>().EnableUpdate_1_View(true);
                graphicsManager.GetComponent<DEMO_GraphicsManager>().GetCurrentScene();
                break;
            case "Prev":
                graphicsManager.GetComponent<DEMO_GraphicsManager>().GetPrevScene();
                break;
            case "Next":
                graphicsManager.GetComponent<DEMO_GraphicsManager>().GetNextScene();
                break;
            default:
                break;
        }

    }
}
=======
﻿//using UnityEngine;

//public class DEMO_SceneNavigation : MonoBehaviour {

//    [SerializeField]
//    private GameObject graphicsManager;
//    [SerializeField]
//    private GameObject soundManager;

//    // Use this for initialization
//    void Start () {

//    }

//    public void ChangeWindows(string nameBt) {
//        soundManager.GetComponent<DEMO_SoundManager>().PlayClickSound();
//        switch (nameBt) {
//            case "ViewUpdateBt":
//                graphicsManager.GetComponent<DEMO_GraphicsManager>().EnableUpdate_1_View(true);
//                graphicsManager.GetComponent<DEMO_GraphicsManager>().GetCurrentScene();
//                break;
//            case "Prev":
//                graphicsManager.GetComponent<DEMO_GraphicsManager>().GetPrevScene();
//                break;
//            case "Next":
//                graphicsManager.GetComponent<DEMO_GraphicsManager>().GetNextScene();
//                break;
//            default:
//                break;
//        }

//    }
//}
>>>>>>> 4d33c8d9516a27c4041c3088b8f825a22da137e3
