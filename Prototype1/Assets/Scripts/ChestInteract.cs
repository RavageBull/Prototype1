using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestInteract : MonoBehaviour
{
    public GameObject chest;
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        chest.GetComponent<InteractableObject>().isChest = true;

        if (sceneName == "Level 6")
        {
            chest.GetComponent<InteractableObject>().isFakeChest = true;
        }
        
    }
}
