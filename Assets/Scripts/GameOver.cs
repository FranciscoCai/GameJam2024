using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string Menu;


    public void CargarEscena()
    {
        SceneManager.LoadScene(Menu);
    }
}
