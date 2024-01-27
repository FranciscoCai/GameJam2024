using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentanaManager : MonoBehaviour
{

    public static VentanaManager instance;
    [SerializeField] private float OlorNecesario;
    private void Awake()
    {
        instance = this;       
    }
    public void ComprobarEstadoVentana(GameObject ventanaDetectado)
    {
        if (ventanaDetectado.name == "Ventana1")
        {
            Ventana ventana = ventanaDetectado.GetComponent<Ventana>();
            if (ventana != null && ventana.estadoVentana == VentanaState.Abierto)
            {
                BarraDeVida.Instance.ActoTerrorista(0, 10);
            }
        }
    }
    private void FastidioOlor()
    {
        
    }
}
