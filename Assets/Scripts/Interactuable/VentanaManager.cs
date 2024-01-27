using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentanaManager : MonoBehaviour
{
    public delegate void DestruirOlor();
    public event DestruirOlor Muertos;

    public static VentanaManager instance;
    private void Awake()
    {
        instance = this;       
    }
    public void ActivarMuerto()
    {
        Muertos?.Invoke();
    }
}
