using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(H * Time.deltaTime, 0, 0));

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * 12;
        }


    }
}
