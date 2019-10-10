using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTexture : MonoBehaviour
{
    public float scrollAmount;
    private Renderer render;
    // Start is called before the first frame update
    void Awake()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        render.material.mainTextureOffset = new Vector2(render.material.mainTextureOffset.x + (scrollAmount * Time.smoothDeltaTime), render.material.mainTextureOffset.y);
    }
}
