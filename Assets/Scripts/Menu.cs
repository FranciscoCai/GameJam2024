using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   

    public string Movement; 

    
    public void CargarEscena()
    {
        
        SceneManager.LoadScene(Movement);
    }
}
