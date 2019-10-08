using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiChosen : MonoBehaviour
{
    public Sprite spriteChange1;
    public Sprite spriteChange2;
    public Sprite spriteChange3;
    // Start is called before the first frame update

    public void potChange()
    {
        GetComponent<SpriteRenderer>().sprite = spriteChange1;
    }
    public void boxChange()
    {
        GetComponent<SpriteRenderer>().sprite = spriteChange2;
    }
    public void barrelChange()
    {
        GetComponent<SpriteRenderer>().sprite = spriteChange3;
    }


}
