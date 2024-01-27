using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentanaOlor : MonoBehaviour
{
    private Ventana ventana;
    [SerializeField] private float OlorNecesario;
    [SerializeField] private float RapidezDeIncremento;
    [SerializeField] private float OlorActual = 0;
    private bool terrorismoCometido = false;
    void Start()
    {
        ventana = gameObject.GetComponent<Ventana>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ventana != null && ventana.estadoVentana == VentanaState.Cerrado)
        {
            OlorActual += RapidezDeIncremento * Time.deltaTime;
        }
        else
        {
            OlorActual -= RapidezDeIncremento * Time.deltaTime;
            if(OlorActual < 0)
            {
                OlorActual = 0;
            }
        }
        if(OlorNecesario< OlorActual && terrorismoCometido == false)
        {
            terrorismoCometido = true;
            TerrorismoOlor();
        }
    }
    private void TerrorismoOlor()
    {
        BarraDeVida.Instance.ActoTerrorista(0, 10);
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.green;
        Destroy(ventana);
        Destroy(this);
    }
}
