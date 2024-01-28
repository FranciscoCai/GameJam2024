using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enchufe : MonoBehaviour, Interactuable
{

    private Animator animator;

    private BoxCollider2D miCollider;

    public GameObject audioSource;

    void Start()
    {

        miCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {




    }

    public void Interactuar()
    {
        audioSource.SetActive(true);
        animator.Play("Cable");
        StartCoroutine(Muerte(0.01f));
        DesactivarCollider();


    }
    IEnumerator Muerte(float tiempoDeEspera)
    {

        yield return new WaitForSeconds(tiempoDeEspera);

        BarraDeVida.Instance.ActoTerrorista(3, 10);

    }
    void DesactivarCollider()
    {

        miCollider.enabled = false;


    }

}
