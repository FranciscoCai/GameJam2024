using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalera : MonoBehaviour, Interactuable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interactuar()
    {
        if (gameObject.transform.localPosition.x == 14.3f && gameObject.transform.localPosition.y == -25.24f)
        {
            Debug.Log(1111);
            BarraDeVida.Instance.ActoTerrorista(2, 10);
        }


    }
}
