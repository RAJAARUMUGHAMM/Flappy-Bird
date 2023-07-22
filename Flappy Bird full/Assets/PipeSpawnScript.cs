using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    private float spawnRate = 2;
    public float timer = 0;
    public float heightOffset=10;
    public GameObject playButton;
    public GameObject Bird;
    // Start is called before the first frame update
    void Start()
    {
     
    
    }
    // Update is called once per frame
    void Update()
    {
        if (playButton.activeInHierarchy == false)
        {
            if (timer < spawnRate)
            {
                timer = timer + Time.deltaTime;
            }
            else
            {
                spawnPipe();
                timer = 0;
            }
        }
    }
    public void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
