using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private float circleArea;
    [SerializeField] private LayerMask gameObjectInteratuable;

    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
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
            }
            else if (objetoDetectado.CompareTag("PlayerBoard"))
            {
                gameObject.transform.position = objetoDetectado.transform.position;
                PlayerGroup.Instance.estadoJugador = PlayerState.Trabajando;
                animator.Play("Trabajo");
                Debug.Log(1);
            }
        }
    }
}
