using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaManager : MonoBehaviour
{
    public delegate void DestruirPuerta();
    public event DestruirPuerta MuertePuerta;
    public static PuertaManager instance;
    void Awake()
    {
        instance = this;
    }
    public void ActivarMuertePuerta()
    {
        MuertePuerta?.Invoke();
    }
}
