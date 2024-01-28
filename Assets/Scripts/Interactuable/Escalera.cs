using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalera : MonoBehaviour, Interactuable
{
    private Animator animator;
    Collider2D miCollider;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        miCollider = GetComponent<Collider2D>();
    }
   
    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.localPosition.x == 14.3f && gameObject.transform.localPosition.y == -25.24f)
        {
            miCollider.enabled = true;

        }
        else
        {
            miCollider.enabled = false;
        }
    }
    public void Interactuar()
    {
        if (gameObject.transform.localPosition.x == 14.3f && gameObject.transform.localPosition.y == -25.24f)
        {
           
            animator.Play("Escalera");
            StartCoroutine(Muerte(1f));
        }
        IEnumerator Muerte(float tiempoDeEspera)
        {

            yield return new WaitForSeconds(tiempoDeEspera);

            BarraDeVida.Instance.ActoTerrorista(2, 50);
            Destroy(gameObject);
        }


    }
}
