using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pauseMenu;
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
            pause(pauseMenu);
        }
    }
    public void startGame(){
        SceneManager.LoadScene(1);
    }

    public void pause(GameObject gameObject){
        isPaused = !isPaused;
        gameObject.SetActive(isPaused);
    }

    public void enterOption(GameObject gameObject){
        gameObject.SetActive(true);
    }

    public void exitOption(GameObject gameObject){
        gameObject.SetActive(false);
    }
}
