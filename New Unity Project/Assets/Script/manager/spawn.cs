using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject block;
    public Transform cenario;
    public int cont = 6, stop, NumSpawn;
    public float tempSpwan;

    void Start()
    {
        
    }
    
    void Update()
    {  
        tempSpwan += 1*Time.deltaTime;
        if(tempSpwan > 4.5f)
        {
            cenario.position = new Vector3(cenario.transform.position.x, cenario.transform.position.y - 0.95f, cenario.transform.position.z);
            tempSpwan = 0;
            NumSpawn++;
        }
        if(stop <= 4 && NumSpawn <= 4 && tempSpwan > 2.15f)
        {
            spawnar();           
        }
    }
    public void spawnar()
    {
        for(float i = 0; i < cont; i++)
        {
            float x = i * 0.93f;
            GameObject temp = Instantiate(block);
            temp.transform.position = new Vector2(transform.position.x + x, transform.position.y);
            temp.transform.SetParent(cenario);
            stop++;                     
        }
        stop = 0;
    }
}
