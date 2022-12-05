using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if(t.phase == TouchPhase.Moved)
            {               
                 transform.position = new Vector3(transform.position.x, (float)-4.12, transform.position.z);
                 transform.position += (Vector3)t.deltaPosition/350;                 
            }
        }
    }
}
