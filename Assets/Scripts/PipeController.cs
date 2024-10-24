using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * GameManager.Instance.pipeSpeed);

        if (transform.position.x <= 3)
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    private void OnMouseDown()
    {
        rb.AddForce(Vector3.up, ForceMode2D.Impulse);
    }
}
