using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentanaManager : MonoBehaviour
{
    public delegate void DestruirOlor();
    public event DestruirOlor Muertos;


    public void ActivarMuerto()
    {
        Muertos?.Invoke();
    }
}
