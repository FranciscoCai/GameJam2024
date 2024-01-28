using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public enum PlayerState
{
    Trabajando, NoTrabajando
}
public class PlayerGroup : MonoBehaviour
{
    [SerializeField] private Image Player;
    [SerializeField] private float ExperienciaNecesariaLosPlayer;
    [SerializeField] private float VelocidadDeAumentoEnPlayer;
    [SerializeField] private float DisminucionDeVelocidad;
    [SerializeField] private float AumentoDeVelocidad;
    private float VelocidadDeAumentoInicial;
    public PlayerState estadoJugador;
    public static PlayerGroup Instance;
    private void Awake()
    {
        Instance = this;
        VelocidadDeAumentoInicial = VelocidadDeAumentoEnPlayer;
    }
    private void Update()
    {
        Player.fillAmount += (Time.deltaTime * VelocidadDeAumentoEnPlayer) / ExperienciaNecesariaLosPlayer;
        switch (estadoJugador)
        {
            case PlayerState.Trabajando:
                if (VelocidadDeAumentoInicial > VelocidadDeAumentoEnPlayer)
                {
                    VelocidadDeAumentoEnPlayer += (Time.deltaTime * AumentoDeVelocidad);
                }
                else
                {
                    VelocidadDeAumentoEnPlayer = VelocidadDeAumentoInicial;
                }
                break;
            case PlayerState.NoTrabajando:
                if (VelocidadDeAumentoEnPlayer > 0)
                {
                    VelocidadDeAumentoEnPlayer -= (Time.deltaTime * DisminucionDeVelocidad);
                }
                else
                {
                    VelocidadDeAumentoEnPlayer = 0;
                }
                break;
        }
        if(Player.fillAmount >= 1) 
        {
            SceneManager.LoadScene("Victoria");
        }
       
    }
}
