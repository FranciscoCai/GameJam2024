using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    [SerializeField] private Image[] Grupos;
    [SerializeField] private float[] ExperienciaNecesariaLosGrupos;

    void Update()
    {
        for (int i = 0; i < Grupos.Length; i++)
        {
            Grupos[i].fillAmount += (Time.deltaTime)/ ExperienciaNecesariaLosGrupos[i];
        }
    }
}
