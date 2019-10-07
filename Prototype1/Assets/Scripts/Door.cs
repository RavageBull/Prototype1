﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public string levelToLoad;
    //public GameObject guiObject;
    // Start is called before the first frame update
    

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
           // guiObject.SetActive(true);
            if (Input.GetButtonDown("Interact"))
            {
                Application.LoadLevel(levelToLoad);
            }
        }
    }



}
