using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalera : MonoBehaviour, Interactuable
{
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
        if (gameObject.transform.localPosition.x == 14.3f && gameObject.transform.localPosition.y == -25.24f)
        {
            Debug.Log(1111);
           
            animator.Play("Escalera");
            StartCoroutine(Muerte(1f));
        }
        IEnumerator Muerte(float tiempoDeEspera)
        {

            yield return new WaitForSeconds(tiempoDeEspera);

            BarraDeVida.Instance.ActoTerrorista(2, 10);
            Destroy(gameObject);
        }


    }
}
