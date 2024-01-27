using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarReloj : MonoBehaviour, Interactuable
{
    [SerializeField] private GameObject RelojCanvas;
    private GameObject Player;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    public void Interactuar()
    {
        RelojCanvas.SetActive(true);
        Player.SetActive(false);
    }
}
