using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Microondas : MonoBehaviour, Interactuable
{

    private Animator animator;
    private BoxCollider2D miCollider;
    [SerializeField] private NPCExplosivo Persona;
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
        animator.Play("Micro");
        miCollider.enabled = false;
        BarraDeVida.Instance.ActoTerrorista(0, 20);
        BarraDeVida.Instance.ActoTerrorista(1, 20);
        BarraDeVida.Instance.ActoTerrorista(2, 20);
        BarraDeVida.Instance.ActoTerrorista(3, 20);
        Persona.DestruirDespues();
        StartCoroutine(AAAAA(0.4f));
    }
    IEnumerator AAAAA(float wait)
    {
        yield return new WaitForSeconds(wait);

        Destroy(gameObject);
    }

}
