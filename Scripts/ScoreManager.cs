using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public Text HighScoreText;

    public float scoreCount;
    public float HighScoreCount;

    public float pointspersecond;
    public float increasePointsPerSecond;

    public bool scoreIncreasing;
    private bool[] L = new bool[5];
    public CoinPickUp iCoin;

   
    



    // Start is called before the first frame update
    private void Start()
    {
        if(PlayerPrefs.HasKey("HighScore"))
        {
            HighScoreCount = PlayerPrefs.GetFloat("HighScore");
            
        }
    }

   

    // Update is called once per frame
    void Update()
    {
        if (scoreIncreasing)
        {
            scoreCount += pointspersecond * Time.deltaTime;
        }
        if(scoreCount >HighScoreCount)
        {
            HighScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", HighScoreCount);
        }

      


        scoreText.text = "" + Mathf.Round(scoreCount);
        HighScoreText.text = "Beat This!  " + Mathf.Round(HighScoreCount);

        //if (!easy && scoreCount >= 20)
        //{
        //    pointspersecond += increasePointsPerSecond * Time.deltaTime;
        //    easy = true;

        //}

        //if (!medium && scoreCount >= 40)
        //{
        //    pointspersecond += increasePointsPerSecond * Time.deltaTime;

        //    medium = true;

        //}

        //if (!hard && scoreCount >= 60)
        //{
        //    pointspersecond += increasePointsPerSecond * Time.deltaTime;
        //    hard = true;

        /* Above Condition is based on the score i.e when score reaches certain number it starts to speed up */

        if (!L[0] && iCoin.coin >= 10)
        {
            pointspersecond += increasePointsPerSecond;
            L[0] = true;
        }

        if (!L[1] && iCoin.coin >= 25)
        {
            pointspersecond += increasePointsPerSecond;
            L[1] = true;

        }

        if (!L[2] && iCoin.coin >= 50)
        {
            pointspersecond += increasePointsPerSecond;
            L[2] = true;
        }

        if (!L[3] && iCoin.coin >= 75)
        {
            pointspersecond += increasePointsPerSecond;
            L[3] = true;
        }

        if (!L[4] && iCoin.coin >= 100)
        {
            pointspersecond += increasePointsPerSecond;
            L[4] = true;
        }

    }

}
