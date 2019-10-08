using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenDoor : MonoBehaviour
{
    public GameObject hiddenDoor;
    public static bool hidden;
    float timeNeeded = 15f;
    float timePassed;
    public bool finishedLevel;
    public bool firstLevel;

    // Start is called before the first frame update
    void Start()
    {
        hiddenDoor.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if (finishedLevel == true)
        {
            hiddenDoor.SetActive(true);
            Debug.Log("damn u suck");
        }

        timePassed += Time.deltaTime;
        if (timePassed > timeNeeded && firstLevel == true)
        {
            hiddenDoor.SetActive(true);
        }
    }
}
