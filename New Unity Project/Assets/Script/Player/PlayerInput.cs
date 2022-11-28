using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public PlayerManger player;

    void Start()
    {
       
    }
    
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        player.move(h);        
    }    
}
