using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addMoneyScript : MonoBehaviour
{
    public float VelY = 200.0f;
    float VelX=0f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(VelX, VelY);
        Destroy(gameObject,1.5f);
    }
}
