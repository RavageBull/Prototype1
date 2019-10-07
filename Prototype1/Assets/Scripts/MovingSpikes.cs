using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpikes : MonoBehaviour
{
    public GameObject startPosition;
    public GameObject endPosition;
    public float moveTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveTime += Time.deltaTime*0.2f;
        this.transform.position = 
            Vector2.Lerp(startPosition.transform.position,
            endPosition.transform.position, moveTime);

        if (this.transform.position == endPosition.transform.position)
        {
            Destroy(this.gameObject);
        }
    }
}
