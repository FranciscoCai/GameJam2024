using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour, Interactuable
{
    private BoxCollider2D miCollider;

    void Start()
    {
      
        miCollider = GetComponent<BoxCollider2D>();

      
        miCollider.isTrigger = false;
    }

    void Update()
    {
        
        
        
            
        
    }

   
    public void Interactuar()
    {
        InvokeRepeating("Terrorism", 0f, 2f);

        CambiarATrigger();


    }
    void Terrorism()
    {
        BarraDeVida.Instance.ActoTerrorista(3, 10);
    }
    void CambiarATrigger()
    {

        miCollider.enabled = false;


    }
}
