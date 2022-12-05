using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolinhaManager : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool iniciou;

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("bloco"))
        {
            Destroy(collision.gameObject);
            rb.AddForce(new Vector2(0,0));
        }
        if (collision.collider.tag.Equals("esquerda") && iniciou)
        {
            rb.AddForce(new Vector2(-3, 3), ForceMode2D.Impulse);
        } 
        else if (collision.collider.tag.Equals("direita") && iniciou)
        {
            rb.AddForce(new Vector2(3, 3), ForceMode2D.Impulse);
        }
    }
}
