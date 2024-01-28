using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajePuerta : MonoBehaviour
{
    [SerializeField] private GameObject Nube;

    private void Start()
    {
        PuertaManager.instance.MuertePuerta += MuerteGrupo4;
    }
    private void OnDestroy()
    {
        PuertaManager.instance.MuertePuerta -= MuerteGrupo4;
    }
    private void OnDisable()
    {
        PuertaManager.instance.MuertePuerta -= MuerteGrupo4;
    }
    public void MuerteGrupo4()
    {
        Nube.SetActive(true);
    }
}
