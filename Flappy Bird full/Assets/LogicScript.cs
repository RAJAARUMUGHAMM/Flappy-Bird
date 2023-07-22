using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore;
    public Text scoreText;
    //public Text highText1;
    //public Text highText2;
    //public Text highText3;
    //public TextMeshProUGUI hight;
    public GameObject gameOverScreen;
    public GameObject gameOvertxt,rebut,homebut;

    public GameObject pauseButton;

    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void home()
    {
        SceneManager.LoadScene("menu");
    }
    public void gameOver()
    {
        highscore();
      
            gameOverScreen.SetActive(true);
        //LeanTween.scale(gameOvertxt, new Vector3(5.5f, 5.5f, 5.5f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveLocal(gameOvertxt, new Vector3(0f, 150f, 0f), .7f).setEase(LeanTweenType.easeInOutCubic);
            LeanTween.scale(gameOvertxt, new Vector3(10.5f, 10.5f, 10.5f), 2f).setEase(LeanTweenType.easeOutCubic);

        
        LeanTween.moveLocal(homebut, new Vector3(200f, -60f, 0f), .7f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(homebut, new Vector3(1.25f, 6f, 1.5f), 2f).setEase(LeanTweenType.easeOutCubic);

        
        LeanTween.moveLocal(rebut, new Vector3(-200f, -60f, 0f), .7f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(rebut, new Vector3(1f, 3f, 1.5f), 2f).setEase(LeanTweenType.easeOutCubic);
        pauseButton.SetActive(false);

        
    }
    public void highscore()
    {
        int temp, temp1;
        if (playerScore > PlayerPrefs.GetInt("HighScore1"))
        {
            temp = PlayerPrefs.GetInt("HighScore1");
            PlayerPrefs.SetInt("HighScore1", playerScore);

            temp1 = PlayerPrefs.GetInt("HighScore2");
            PlayerPrefs.SetInt("HighScore2", temp);
            PlayerPrefs.SetInt("HighScore3", temp1);
        }

        else if (playerScore > PlayerPrefs.GetInt("HighScore2") && playerScore != PlayerPrefs.GetInt("HighScore1"))
        {
            temp = PlayerPrefs.GetInt("HighScore2");
            PlayerPrefs.SetInt("HighScore2", playerScore);
            PlayerPrefs.SetInt("HighScore3", temp);
        }

        else if (playerScore > PlayerPrefs.GetInt("HighScore3") && playerScore != PlayerPrefs.GetInt("HighScore1")
            && playerScore != PlayerPrefs.GetInt("HighScore2"))
        {
            PlayerPrefs.SetInt("HighScore3", playerScore);
        }

        //highText1.text = PlayerPrefs.GetInt("HighScore1").ToString();
        //highText2.text = PlayerPrefs.GetInt("HighScore2").ToString();
        //highText3.text = PlayerPrefs.GetInt("HighScore3").ToString();
    }
}
