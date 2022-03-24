using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titlePage : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject intromenu;
    private bool is_intro = false;

    private void Update() {
        if(is_intro && Input.GetButtonDown("Cancel")){
            show_mainmenu();
        }
    }
    public void StartGame(){
        Time.timeScale = 1;
        SceneManager.LoadScene("level_1");
    }

    /*
    public void show_instruction(){
        is_intro = true;
        mainmenu.SetActive(false);
        intromenu.SetActive(true);
    }
    */
    public void show_mainmenu(){
        is_intro = false;
        mainmenu.SetActive(true);
        intromenu.SetActive(false);
    }

    public void ExitGame(){
        print("Quit Game!");
        Application.Quit();
    }
}
