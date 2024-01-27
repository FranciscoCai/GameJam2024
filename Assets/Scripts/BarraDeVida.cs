using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarraDeVida : MonoBehaviour
{

    [SerializeField] private Image[] Grupos;
    [SerializeField] private float[] ExperienciaNecesariaLosGrupos;
    [SerializeField] private float[] VelocidadDeAumentoEnGrupo;
    public static BarraDeVida Instance;
    public string GameOver;

    private void Start()
    {
        Instance = this;

        VentanaManager.instance.Muertos += MuerteGrupo2;
    }
    void Update()
    {
        for (int i = 0; i < Grupos.Length; i++)
        {
            Grupos[i].fillAmount += (Time.deltaTime * VelocidadDeAumentoEnGrupo[i])/ ExperienciaNecesariaLosGrupos[i];
            if (Grupos[i].fillAmount ==1)
            {
                SceneManager.LoadScene(GameOver);
            }
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
    private void MuerteGrupo2()
    {
        VelocidadDeAumentoEnGrupo[1] = 0;
    }
    private void OnDestroy()
    {
        VentanaManager.instance.Muertos -= MuerteGrupo2;
    }
    private void OnDisable()
    {
        VentanaManager.instance.Muertos -= MuerteGrupo2;
    }
}
