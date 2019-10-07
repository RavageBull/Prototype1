using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteract : MonoBehaviour
{
    public GameObject chest;
    // Start is called before the first frame update
    void Start()
    {
        chest.GetComponent<InteractableObject>().isChest = true;
    }
}
