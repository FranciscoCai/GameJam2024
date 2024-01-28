using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonasExplosion : MonoBehaviour
{
    private Animator animator;

    public GameObject Explosion;

    private void Start()
    {
        animator = GetComponent<Animator>();
        ExplosionManager.instance.MuerteExplosion += MuerteGrupo1;
    }
    private void OnDestroy()
    {
        ExplosionManager.instance.MuerteExplosion -= MuerteGrupo1;
    }
    private void OnDisable()
    {
        ExplosionManager.instance.MuerteExplosion -= MuerteGrupo1;
    }
    public void MuerteGrupo1()
    {
        animator.Play("BoomJuan");
        animator.Play("BoomTu");
        animator.Play("BoomTree");
        Explosion.SetActive(true);
        StartCoroutine(Muerte(0.3f));

    }
    IEnumerator Muerte(float tiempoDeEspera)
    {

        yield return new WaitForSeconds(tiempoDeEspera);

        
        Destroy(gameObject);
    }
}
