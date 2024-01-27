using UnityEngine;

public class PersonasVentana : MonoBehaviour
{
    private GameObject ObjetoVentanaManager;
    private VentanaManager ventanaManager;
    [SerializeField]  private GameObject Particulas;
    [SerializeField] private Sprite CambioSpritePersona;

    void Start()
    {
        ObjetoVentanaManager = GameObject.Find("VentanaManager");
        ventanaManager = ObjetoVentanaManager.GetComponent<VentanaManager>();
        ventanaManager.Muertos += MuerteGrupo2;
    }
    private void MuerteGrupo2()
    {
        SpriteRenderer spritePersonaje = gameObject.GetComponent<SpriteRenderer>(); 
        spritePersonaje.sprite = CambioSpritePersona;
        Quaternion rotacionDeseada = Quaternion.Euler(-90f, 0f, 0f);
        Instantiate(Particulas,gameObject.transform.position,rotacionDeseada);
    }
    private void OnDestroy()
    {
        ventanaManager.Muertos -= MuerteGrupo2;
    }
    private void OnDisable()
    {
        ventanaManager.Muertos -= MuerteGrupo2;
    }
}
