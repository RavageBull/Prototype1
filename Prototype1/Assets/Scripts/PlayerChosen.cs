using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChosen : MonoBehaviour
{
    public GameObject hiddenDoor;
    public Sprite spriteChange1;
    public Sprite spriteChange2;
    public Sprite spriteChange3;
    public AudioSource lose;
    // Start is called before the first frame update
    public int scoreCount = 0;

    private void Start()
    {
        lose = GetComponent<AudioSource>();
    }
    public void potChange()
    {
        GetComponent<SpriteRenderer>().sprite = spriteChange1;
        Debug.Log("you lose");
        lose.Play();
        scoreCount++;
    }
    public void boxChange()
    {
        GetComponent<SpriteRenderer>().sprite = spriteChange2;
        Debug.Log("you lose");
        lose.Play();
        scoreCount++;
    
    }
    public void barrelChange()
    {
        GetComponent<SpriteRenderer>().sprite = spriteChange3;
        Debug.Log("you lose");
        lose.Play();
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
