using UnityEngine;

public class Puerta : MonoBehaviour, Interactuable
{
    private BoxCollider2D miCollider;
    private Animator animator;
    void Start()
    {
        miCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        miCollider.isTrigger = false;
    }
    public void Interactuar()
    {
        animator.Play("Puerta");
        InvokeRepeating("Terrorism", 0f, 2f);
        CambiarATrigger();
    }
    void Terrorism()
    {
        BarraDeVida.Instance.ActoTerrorista(3, 10);
    }
    void CambiarATrigger()
    {
        PuertaManager.instance.ActivarMuertePuerta();
        miCollider.enabled = false;
    }
}
