using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonaAire : MonoBehaviour
{
    private GameObject ObjetoAireManager;
    private AireManager aireManager;
    [SerializeField] private GameObject Nube;
    [SerializeField] private Sprite CambioSpritePersona;

    void Start()
    {
        ObjetoAireManager = GameObject.Find("AireManager");
        aireManager = ObjetoAireManager.GetComponent<AireManager>();
        aireManager.MuertosAire += MuerteGrupo3;
    }

    private void MuerteGrupo3()
    {
        SpriteRenderer spritePersonaje = gameObject.GetComponent<SpriteRenderer>();
        spritePersonaje.sprite = CambioSpritePersona;
        BarraDeVida.Instance.VelocidadDeAumentoEnGrupo[2] = 0;
        Nube.SetActive(true);
    }
    private void OnDestroy()
    {
        aireManager.MuertosAire -= MuerteGrupo3;
    }
    private void OnDisable()
    {
        aireManager.MuertosAire -= MuerteGrupo3;
    }
}
