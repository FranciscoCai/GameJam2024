using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{

    [SerializeField] private Image[] Grupos;
    [SerializeField] private float[] ExperienciaNecesariaLosGrupos;
    [SerializeField] private float[] VelocidadDeAumentoEnGrupo;
    public static BarraDeVida Instance;

    private void Awake()
    {
        Instance = this;
    }
    void Update()
    {
        for (int i = 0; i < Grupos.Length; i++)
        {
            Grupos[i].fillAmount += (Time.deltaTime * VelocidadDeAumentoEnGrupo[i])/ ExperienciaNecesariaLosGrupos[i];
        }
    }
    public void ActoTerrorista(int numeroDeEquipo, float numeroDeTerrorismo)
    {
        Grupos[numeroDeEquipo].fillAmount -= numeroDeTerrorismo/ ExperienciaNecesariaLosGrupos[numeroDeEquipo];
        if(Grupos[numeroDeEquipo].fillAmount< 0)
        {
            Grupos[numeroDeEquipo].fillAmount = 0;
        }
    }
    
}
