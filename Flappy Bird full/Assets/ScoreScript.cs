using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI high1;
    public TextMeshProUGUI high2;
    public TextMeshProUGUI high3;
    // Start is called before the first frame update
    void Start()
    {
        high1.text = PlayerPrefs.GetInt("HighScore1").ToString();
        high2.text = PlayerPrefs.GetInt("HighScore2").ToString();
        high3.text = PlayerPrefs.GetInt("HighScore3").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
