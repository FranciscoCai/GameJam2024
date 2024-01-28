using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonasExplosion : MonoBehaviour
{
    private void Start()
    {
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
      
    }
}
