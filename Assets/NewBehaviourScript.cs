using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Vector2 move = new Vector2(x, 0);
        transform.Translate(move * speed * Time.deltaTime);
    }
}