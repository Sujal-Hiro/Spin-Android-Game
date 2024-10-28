using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource gameMusic;
    public AudioSource gameOverMusic;

    public bool gameSound;
    public bool gameOverSound;

    public void GameMusic()
    {
        gameSound = true;
        gameOverSound = false;
        gameMusic.Play();

    }

    public void GameOverMusic()
    {
        if (gameMusic.isPlaying)
            gameSound = false;
        {
            gameMusic.Stop();
        }
        if(!gameOverMusic.isPlaying && gameOverSound == false)
        {
            gameOverMusic.Play();
            gameOverSound = true;
        }
    }
}
