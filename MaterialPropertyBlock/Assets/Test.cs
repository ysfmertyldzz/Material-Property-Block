using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public Color color = Color.black;

    Renderer renderer;
    MaterialPropertyBlock propertyBlock;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        propertyBlock = new MaterialPropertyBlock();
    }

    private void Update()
    {
        propertyBlock.SetColor("_Color", color);
        renderer.SetPropertyBlock(propertyBlock);
    }
}
