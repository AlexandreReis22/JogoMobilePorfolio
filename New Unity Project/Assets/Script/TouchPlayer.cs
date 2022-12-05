using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPlayer : MonoBehaviour
{
    public BolinhaManager bolinha;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if (!bolinha.iniciou)
            {
                bolinha.iniciou = true;
                bolinha.transform.SetParent(null);
                bolinha.rb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
            }
            if(t.phase == TouchPhase.Moved)
            {               
                 transform.position = new Vector3(transform.position.x, (float)-4.12, transform.position.z);
                 transform.position += (Vector3)t.deltaPosition/200;                 
            }      
        }
    }
}
