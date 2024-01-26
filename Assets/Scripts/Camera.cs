using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform jugador;  // Referencia al transform del jugador
    public float suavizado = 5f;  // Suavizado de movimiento de la cámara

    void FixedUpdate()
    {
        if (jugador != null)
        {
            // Calcular la posición deseada de la cámara
            Vector3 posicionDeseada = new Vector3(jugador.position.x, jugador.position.y, transform.position.z);

            // Mover la cámara hacia la posición deseada con suavizado
            transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavizado * Time.deltaTime);
        }
    }
}
