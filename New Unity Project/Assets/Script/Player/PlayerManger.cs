using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerManger : MonoBehaviour
{
    public Rigidbody2D rb;
    public float vel;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
    }

    public void move(float h)
    {        
        rb.velocity = new Vector2(h * vel * Time.deltaTime, rb.velocity.y);
    }
}
