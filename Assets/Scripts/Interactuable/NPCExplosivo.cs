using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCExplosivo : MonoBehaviour
{
    public Microondas microondas;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame

    public IEnumerator Muerte(float tiempoDeEspera)
    {
        animator.Play("Alfonso");
        yield return new WaitForSeconds(tiempoDeEspera);
        Destroy(gameObject);
    }
}
