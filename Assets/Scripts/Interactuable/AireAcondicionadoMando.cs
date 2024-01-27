using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AireAcondicionadoMando : MonoBehaviour, Interactuable
{
    [SerializeField] private GameObject CanvasAire;
    public void Interactuar()
    {
        CanvasAire.SetActive(true);
        Destroy(gameObject);
    }
}
