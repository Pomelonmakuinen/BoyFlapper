using System;
using TMPro;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float thrust = 5f;
    public int score = 0;

    public Rigidbody2D rb2D;
    public GameObject start;
    public GameObject overText;
    public TextMeshProUGUI scoreTxt;
    public AudioSource src;

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
            score++;
            scoreTxt.text = Convert.ToString(score);
            src.Play();
        }
        else
        {
            start.SetActive(true);
            overText.SetActive(true);
            Time.timeScale = 0;
        }
    }


}
