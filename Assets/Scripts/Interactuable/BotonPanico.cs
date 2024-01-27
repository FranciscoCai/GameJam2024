using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPanico : MonoBehaviour, Interactuable
{
    public bool suicido = false;

    private Animator animator;
    private BoxCollider2D miCollider;
    // Start is called before the first frame update
    void Start()
    {
        miCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interactuar()
    {
        suicido = true;

        animator.Play("Boton");

        StartCoroutine(Muerte(0.15f));
        DesactivarCollider();


    }
    IEnumerator Muerte(float tiempoDeEspera)
    {

        yield return new WaitForSeconds(tiempoDeEspera);

        Destroy(animator);

    }
    void DesactivarCollider()
    {

        miCollider.enabled = false;


    }
}
