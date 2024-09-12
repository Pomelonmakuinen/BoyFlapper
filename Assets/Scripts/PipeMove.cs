using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float scrollSpeed = 5f;
    public Vector2 scrollDirection = Vector2.right;

    public void Update()
    {
        transform.Translate(scrollDirection * scrollSpeed * Time.deltaTime);

        if (gameObject.transform.position.x < -5)
        {
            Destroy(gameObject);
        }
    }
}
