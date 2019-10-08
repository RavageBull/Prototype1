using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChosen : MonoBehaviour
{
    public GameObject hiddenDoor;
    public Sprite spriteChange1;
    public Sprite spriteChange2;
    public Sprite spriteChange3;
    // Start is called before the first frame update
    public int scoreCount = 0;

    public void potChange()
    {
        GetComponent<SpriteRenderer>().sprite = spriteChange1;
        Debug.Log("you lose");
        scoreCount++;
    }
    public void boxChange()
    {
        GetComponent<SpriteRenderer>().sprite = spriteChange2;
        Debug.Log("you lose");
        scoreCount++;
    }
    public void barrelChange()
    {
        GetComponent<SpriteRenderer>().sprite = spriteChange3;
        Debug.Log("you lose");
        scoreCount++;
    }

    void Update()
    {
        if (scoreCount >= 10)
        {
            GetComponent<HiddenDoor>().finishedLevel = true;
        }
    }
}
