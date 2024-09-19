using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class backg_scroll : MonoBehaviour
{
    public float speed;

    [SerializeField]
    private Renderer bgRend;

    void Update()
    {
        bgRend.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}