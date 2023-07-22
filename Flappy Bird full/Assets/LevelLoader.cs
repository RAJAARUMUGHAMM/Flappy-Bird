using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public string scene;
    public float timer=1.25f;
    

    public void loadnextlevel()
    {
        StartCoroutine(Loadlevel(scene));
       
    }
    
    IEnumerator Loadlevel(string scene)
    {

        Time.timeScale = 1f;
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(timer);
        SceneManager.LoadScene(scene);
    }
}
