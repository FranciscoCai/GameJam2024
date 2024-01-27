using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAireAcondicionado : MonoBehaviour, Interactuable
{
    [SerializeField] private GameObject CanvasAire;
    public void Interactuar()
    {
        if(CanvasAire.activeSelf)
        {
            BarraDeVida.Instance.ActoTerrorista(1, 10);
            Destroy(CanvasAire);
            Destroy(this);
        }

    }
}
