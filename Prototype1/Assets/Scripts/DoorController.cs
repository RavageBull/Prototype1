using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject Door;
    public bool doorIsOpening = true;
    
    
    // Update is called once per frame
    void Update()
    {
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector2.up * Time.deltaTime * 5);
        }
        if(Door.transform.position.y > 1f)
        {
            doorIsOpening = false;
        }
    }

  




}
