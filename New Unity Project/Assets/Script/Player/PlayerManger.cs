using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class PlayerManger : MonoBehaviour
{
    public Rigidbody2D rb, rbBoll;
    public float vel, forcePulo;    

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("bolinha"))
        {            
            rbBoll.AddForce(Vector2.up * forcePulo, ForceMode2D.Impulse);
        }
    }   
}
