using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchIncrease : MonoBehaviour
{
    public ScoreManager score;
    AudioSource audioSource;
    public float pitchToIncrease = 1f;
    public float incrementPitch = 0.01f;
    private bool[] Score = new bool[11];
    public BallRotation speed;
    public Moving enemySpeed;
    public float multiplier = 1.2f;
    public float multiplierEnemy = 0.2f;


    void Start()
    {
        enemySpeed.enemyS = 2f;
        audioSource = GetComponent<AudioSource>();
    }



    void Update()
    {
        if (!Score[0] && score.scoreCount >= 300)
        {
            speed._speed *= multiplier;
            enemySpeed.enemyS += multiplierEnemy;
            Score[0] = true;
        }

        if (!Score[1] && score.scoreCount >= 600)
        {
            audioSource.pitch = pitchToIncrease += incrementPitch;          
            Score[1] = true;
        }

        if (!Score[2] && score.scoreCount >= 900)
        {
            speed._speed *= multiplier;
            enemySpeed.enemyS += multiplierEnemy;
            Score[2] = true;
        }

        if (!Score[3] && score.scoreCount >= 1200)
        {
            audioSource.pitch = pitchToIncrease += incrementPitch;         
            Score[3] = true;
        }

        if (!Score[4] && score.scoreCount >= 1500)
        {
            speed._speed *= multiplier;
            enemySpeed.enemyS += multiplierEnemy;
            Score[4] = true;
        }

        if (!Score[5] && score.scoreCount >= 1800)
        {
            audioSource.pitch = pitchToIncrease += incrementPitch;          
            Score[5] = true;
        }

        if (!Score[6] && score.scoreCount >= 2100)
        {
            speed._speed *= multiplier;
            enemySpeed.enemyS += multiplierEnemy;
            Score[6] = true;
        }

        if (!Score[7] && score.scoreCount >= 2400)
        {
            audioSource.pitch = pitchToIncrease += incrementPitch;          
            Score[7] = true;
        }

        if (!Score[8] && score.scoreCount >= 2700)
        {
            speed._speed *= multiplier;
            enemySpeed.enemyS += multiplierEnemy;
            Score[8] = true;
        }

        if (!Score[9] && score.scoreCount >= 3000)
        {
            audioSource.pitch = pitchToIncrease += incrementPitch;
            Score[9] = true;
        }

        if (!Score[10] && score.scoreCount >= 3350)
        {
            speed._speed *= multiplier;
            enemySpeed.enemyS += multiplierEnemy;
            Score[10] = true;
        }
    }
}
