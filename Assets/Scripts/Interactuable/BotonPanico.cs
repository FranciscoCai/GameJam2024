using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPanico : MonoBehaviour, Interactuable
{
    public bool suicido = false;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
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


    }
    IEnumerator Muerte(float tiempoDeEspera)
    {

        yield return new WaitForSeconds(tiempoDeEspera);

        Destroy(animator);

    }
}
