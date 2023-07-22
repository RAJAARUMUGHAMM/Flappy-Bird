using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionTimer
{
    private static List<FunctionTimer> activeTimeListener; //holds a reference to all active timers
    private static GameObject initgameobject; //global gameobject used for initialize class, destroyed during scene change
    private static void initneeded()
    {
        if (initgameobject == null)
        {
            initgameobject = new GameObject("FunctionTimer_initGameObject");
            activeTimeListener = new List<FunctionTimer>();
        }
    }
    
    public static FunctionTimer Create(Action action,float timer,string timername=null)
    {
        initneeded();
        GameObject gameObject = new GameObject("FunctionTimer", typeof(MonobehaviourHook));
        FunctionTimer functiontimer = new FunctionTimer(action, timer,timername,gameObject);
        
        gameObject.GetComponent<MonobehaviourHook>().onUpdate = functiontimer.update;
    
        activeTimeListener.Add(functiontimer);

        return functiontimer;
    }
    private static void RemoveList(FunctionTimer functionTimer)
    {
        initneeded();
        activeTimeListener.Remove(functionTimer);
    }
    public static void stoptimer(string timername)
    {
        for(int i = 0; i < activeTimeListener.Count; i++)
        {
            if (activeTimeListener[i].timername == timername)
            {
                activeTimeListener[i].destroy();
                i--;
            }
        }
    }
    private class MonobehaviourHook : MonoBehaviour
    {
        public Action onUpdate;
        void Update()
        {
            if (onUpdate != null)
            {
                onUpdate();
            }
        }
    }
    private Action action;
    private float timer;
    private bool isdestroyed;
    private string timername;
    public GameObject gameObject;
    public FunctionTimer(Action action,float timer,string timername,GameObject gameObject)
    {
        this.action = action;
        this.timer = timer;
        this.timername = timername;
        this.gameObject = gameObject;
    }
    public void update()
    {
        if (isdestroyed == false)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                action();
                destroy();
            }
        }
    }
    public void destroy()
    {
        isdestroyed = true;
        UnityEngine.Object.Destroy(gameObject);
        RemoveList(this);
    }
}
