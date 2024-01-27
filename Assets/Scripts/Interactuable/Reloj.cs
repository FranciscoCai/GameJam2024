using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reloj : MonoBehaviour
{
    [SerializeField] private Sprite[] Horas;
    private int imagenDeAhora = 0;
    private Image image;
    private GameObject Player;
    [SerializeField]  private GameObject Padre;
    private void Start()
    {

        image = Padre.GetComponent<Image>();
        image.sprite = Horas[imagenDeAhora];
        
    }
    private void OnEnable()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    public void CambioDeHoras()
    {
        imagenDeAhora += 1;
        if(imagenDeAhora > Horas.Length-1)
        {
            imagenDeAhora = 0;
        }
        image.sprite = Horas[imagenDeAhora];
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Player.SetActive(true);
            Padre.SetActive(false);
        }
    }
}
