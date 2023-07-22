using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength=15;
    public LogicScript logic;
    public PipeSpawnScript logic1;
    public bool isBirdAlive = true;
    public GameObject playButton;
    public GameObject Bird;
    public GameObject PipeSpawn;
    public AudioSource birdchirp;
    public GameObject Score;
    public GameObject pauseButton;
    public GameObject scoretxt;
    public GameObject scorebox;
    // Start is called before the first frame update
    void Start()
    {
        playButton.SetActive(true);
        Bird.SetActive(false);
        pauseButton.SetActive(false);
       
    }
    public void gameStart()
    {
        scoretxt.SetActive(true);
        scorebox.SetActive(true);
        Score.SetActive(true);
        playButton.SetActive(false);
        pauseButton.SetActive(true);
        Bird.SetActive(true);
        PipeSpawn.SetActive(true);
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        logic1 = GameObject.FindGameObjectWithTag("PipeSpawn").GetComponent<PipeSpawnScript>();
        
    }
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0)&& isBirdAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
    private void OnBecameInvisible()
    {
        
        logic.gameOver();
        PipeSpawn.SetActive(false);
     
        Destroy(Bird);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        PipeSpawn.SetActive(false);
        isBirdAlive = false;
    }
}
