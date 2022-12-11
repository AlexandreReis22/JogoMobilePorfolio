using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class habilidades : MonoBehaviour
{
    public int IdHabilidade = -1;
    public GameObject Id0Bolinhas;
    public Transform bolinha;

    void Start()
    {
        
    }

    
    void Update()
    {
        switch (IdHabilidade)
        {
            case 0:
                GameObject temp =Instantiate(Id0Bolinhas);
                temp.transform.position = bolinha.transform.position;
                break;
        }
    }
}
