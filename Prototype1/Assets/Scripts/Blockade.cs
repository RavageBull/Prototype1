using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockade : MonoBehaviour
{
    float timeToOpen = 1f;
    float blockadeTimer;
    public void Open()
    {
        blockadeTimer = timeToOpen;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (blockadeTimer > 0)
        {
            transform.Translate(Vector2.up * Time.deltaTime * 5);
            blockadeTimer -= Time.deltaTime;
        }
    }
}
