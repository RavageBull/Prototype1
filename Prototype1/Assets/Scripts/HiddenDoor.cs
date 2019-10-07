using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenDoor : MonoBehaviour
{
    public GameObject hiddenDoor;
    public static bool hidden;
    float timeNeeded = 20f;
    float timePassed;

    // Start is called before the first frame update
    void Start()
    {
        hiddenDoor.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > timeNeeded)
        {
            hiddenDoor.SetActive(true);
        }
    }
}
