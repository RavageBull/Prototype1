using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject currentInterObj = null;
    public string levelToLoad;
    public AudioSource death;

    private void Start()
    {
        death = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if(Input.GetButtonDown ("Interact") && currentInterObj)
        {
            //Do stuff with the object
            currentInterObj.SendMessage("DoInteraction");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("interObject"))
        {
            Debug.Log(other.name);
            currentInterObj = other.gameObject;
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("interObject"))
        {
           if (other.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }
        }

        else if (other.gameObject.tag == "Death")
        {
            death.Play();
            StartCoroutine(die());
        }
    }

    IEnumerator die()
    {
        yield return new WaitForSeconds(1);
        Application.LoadLevel(levelToLoad);
    }
}


