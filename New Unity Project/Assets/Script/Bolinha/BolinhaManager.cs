using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolinhaManager : MonoBehaviour
{
    public Rigidbody2D rb;

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
        }
    }
}
