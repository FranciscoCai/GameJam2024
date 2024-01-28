using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoCreditos : MonoBehaviour
{
    [SerializeField] private VideoPlayer video;
    void Start()
    {
        video = GetComponent<VideoPlayer>();
        video.loopPointReached += PasoDeEscena;
    }
    private void PasoDeEscena(VideoPlayer vp)
    {
        SceneManager.LoadScene("MainMenu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
