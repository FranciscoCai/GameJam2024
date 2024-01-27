using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private float circleArea;
    [SerializeField] private LayerMask gameObjectInteratuable;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            DetectGameObject();
        }
    }
    private void DetectGameObject()
    {
        Collider2D objetoDetectado = Physics2D.OverlapCircle(transform.position, circleArea, gameObjectInteratuable);

        if (objetoDetectado != null)
        {
            if (objetoDetectado.CompareTag("Enemy"))
            {
                if (objetoDetectado.TryGetComponent(out Interactuable interactuable))
                {
                    interactuable.Interactuar();
                }
                //BarraDeVida.Instance.ActoTerrorista(0, 10);
            }
            else if (objetoDetectado.CompareTag("PlayerBoard"))
            {
                gameObject.transform.position = objetoDetectado.transform.position;
                PlayerGroup.Instance.estadoJugador = PlayerState.Trabajando;
            }
        }
    }
}
