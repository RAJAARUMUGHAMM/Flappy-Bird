using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseScript : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseButton;
    //public GameObject animate;
    //public GameObject animate1;


    // Start is called before the first frame update
    void Start()
    {
        Resume();
    }
    // Update is called once per frame
    void Update()
    {
       

    }
    public void Resume()
    {
        pauseButton.SetActive(true);
       
       
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }
    public void mainmenu()
    {
        Debug.Log("load");
        
      

        SceneManager.LoadScene("menu");
    }
    public void Pause()
    {
        pauseButton.SetActive(false);
  
        Cursor.visible = true;
      
        Time.timeScale = 0f;
    
        
        pauseMenuUI.SetActive(true);
        isPaused = true;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
