using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum VentanaState
{
    Abierto, Cerrado
}
public class Ventana : MonoBehaviour, Interactuable
{
    public VentanaState estadoVentana;
    private SpriteRenderer spriteVentana;
    [SerializeField] private Sprite[] SpriteEstadoVentana;
    private void Awake()
    {
        spriteVentana = gameObject.GetComponent<SpriteRenderer>();
    }
    public void Interactuar()
    {
        switch (estadoVentana)
        {
            case VentanaState.Abierto:
                estadoVentana = VentanaState.Cerrado;
                break;
            case VentanaState.Cerrado:
                estadoVentana = VentanaState.Abierto;
                break;
        }
        CambioSpriteVentana();
    }

    private void CambioSpriteVentana()
    {
        switch (estadoVentana)
        {
            case VentanaState.Abierto:
                spriteVentana.sprite = SpriteEstadoVentana[0];
                break;
            case VentanaState.Cerrado:
                spriteVentana.sprite = SpriteEstadoVentana[1];
                break;
        }
    }
    private void Start()
    {
        CambioSpriteVentana();
    }
}
