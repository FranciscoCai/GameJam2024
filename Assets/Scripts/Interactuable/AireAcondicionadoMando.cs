using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AireAcondicionadoMando : MonoBehaviour, Interactuable
{
    [SerializeField] private GameObject CanvasAire;
    [SerializeField] private GameObject AireEscena;
    public void Interactuar()
    {
        CanvasAire.SetActive(true);
        Collider2D miCollider = AireEscena.GetComponent<Collider2D>();
        miCollider.enabled = true;
        Destroy(gameObject);
    }
}
