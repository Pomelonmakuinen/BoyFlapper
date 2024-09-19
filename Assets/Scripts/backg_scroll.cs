using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backg_scroll : MonoBehaviour
{
    public float scrollspeed = 1f;

    public Material mat;

    public float offset = 0f;

    private void Start()
    {
        InvokeRepeating("scroll", 0f, scrollspeed);
    }

    private void scroll()
    {
    }
}