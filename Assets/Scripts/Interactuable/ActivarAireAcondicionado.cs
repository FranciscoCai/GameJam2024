using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAireAcondicionado : MonoBehaviour, Interactuable
{
    [SerializeField] private GameObject CanvasAire;
    private GameObject ObjetoAireManager;
    private AireManager aireManager;
    void Start()
    {
        ObjetoAireManager = GameObject.Find("AireManager");
        aireManager = ObjetoAireManager.GetComponent<AireManager>();
    }
    public void Interactuar()
    {
        if(CanvasAire.activeSelf)
        {
            aireManager.ActivarMuertoAire();
            Destroy(CanvasAire);
            Destroy(this);
        }

    }
}
