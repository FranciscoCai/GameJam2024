using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AireManager : MonoBehaviour
{
    public delegate void DestruirAire();
    public event DestruirAire MuertosAire;
    public void ActivarMuertoAire()
    {
        MuertosAire?.Invoke();
    }
}
