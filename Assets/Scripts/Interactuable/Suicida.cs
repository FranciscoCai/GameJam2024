using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suicida : MonoBehaviour
{
    public BotonPanico botonPanico;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        BotonPanico botonPanico = Object.FindFirstObjectByType<BotonPanico>();
        bool death = botonPanico.suicido;

        if (death == true)
        {
            Debug.Log("odio mi via");
            animator.Play("Suicidio");
            StartCoroutine(Muerte(5f));
        }
    }
    IEnumerator Muerte(float tiempoDeEspera)
    {
        
        yield return new WaitForSeconds(tiempoDeEspera);

        BarraDeVida.Instance.ActoTerrorista(0, 10);
        Destroy(gameObject);
    }
}
