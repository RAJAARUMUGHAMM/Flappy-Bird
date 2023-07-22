using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public String SceneName;

    [SerializeField] private GameObject endTransition;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //startTransition.SetActive(true);
        //FunctionTimer.Create(disableTransition, 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void menutransition() { 
            endTransition.SetActive(true);
            FunctionTimer.Create(loadscene, 1f);
    }
    private void loadscene()
    {
        SceneManager.LoadScene(SceneName);
    }
    //private void disableTransition()
    //{
    //    startTransition.SetActive(false);
    //}
}
