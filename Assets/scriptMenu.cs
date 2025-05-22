using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scriptMenu : MonoBehaviour{

    private AudioSource som;

    void Start() {
        // Obter o AudioSource ao iniciar
        som = GetComponent<AudioSource>();
    }
    public void iniciar() {

        if (som != null) {
            som.Play();
            
        }

        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(1);
    }
    
    public void sair() {
        Application.Quit();
    }
}
