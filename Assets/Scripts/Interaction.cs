using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private float circleArea;
    [SerializeField] private LayerMask gameObjectInteratuable;
    [SerializeField] private GameObject FIndicacion;

    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
            DetectGameObject();
    }
    private void DetectGameObject()
    {
        Collider2D objetoDetectado = Physics2D.OverlapCircle(transform.position, circleArea, gameObjectInteratuable);
        if(PlayerGroup.Instance.estadoJugador == PlayerState.Trabajando )
        {
            FIndicacion.SetActive(false);
        }
        else if (objetoDetectado != null)
        {
            FIndicacion.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (objetoDetectado.CompareTag("Enemy"))
                {
                    if (objetoDetectado.TryGetComponent(out Interactuable interactuable))
                    {
                        interactuable.Interactuar();
                    }
                }
                else if (objetoDetectado.CompareTag("PlayerBoard"))
                {
                    gameObject.transform.position = objetoDetectado.transform.position;
                    PlayerGroup.Instance.estadoJugador = PlayerState.Trabajando;
                }
            }
        }
        else
        {
            FIndicacion.SetActive(false);
        }
    }
}
