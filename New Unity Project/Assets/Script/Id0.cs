using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Id0 : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool esquerda;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("bloco"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.collider.tag.Equals("esquerda"))
        {
            rb.AddForce(new Vector2(-10f, 10f), ForceMode2D.Impulse);
            esquerda = true;
        } else if (collision.collider.tag.Equals("direita"))
        {
            rb.AddForce(new Vector2(10f, 10f), ForceMode2D.Impulse);
        }
    }
}
