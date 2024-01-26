using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private float circleArea;
    private bool gameObjectExist;
    [SerializeField] private LayerMask gameObjectInteratuable;
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            DetectGameObject();
        }
    }
    private void DetectGameObject()
    {
        gameObjectExist = Physics2D.OverlapCircle(this.transform.position, circleArea, gameObjectInteratuable);
        if (gameObjectExist)
        {
            BarraDeVida.Instance.ActoTerrorista(0, 10);
        }
    }
}
