using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.DeviceSimulation;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float thrust = 5f;
    public int score = 0;

    public Rigidbody2D rb2D;
    public TextMeshProUGUI scoreTxt;

    public bool tapped = false;

    public void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    public void Tap()
    {
        rb2D.AddForce(transform.up * thrust);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "pipe")
        {
            Debug.Log("passed through a pipe");
            score++;
            scoreTxt.text = Convert.ToString(score);
        }
        else
        {
            Debug.Log("Entered 2d collider");
            SceneManager.LoadScene("SampleScene");
        }
    }


}
