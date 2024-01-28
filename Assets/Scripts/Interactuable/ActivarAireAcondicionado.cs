using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAireAcondicionado : MonoBehaviour, Interactuable
{
    [SerializeField] private GameObject CanvasAire;
    private GameObject ObjetoAireManager;
    public GameObject sound;

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
            sound.SetActive(true);
            aireManager.ActivarMuertoAire();
            Collider2D miCollider = GetComponent<Collider2D>();
            miCollider.enabled = false;
            Destroy(CanvasAire);
            Destroy(this);
        }

    }
}
