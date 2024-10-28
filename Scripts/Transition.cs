using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public Animator Fade;
    public float tTime = 1f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadNextLevel();
        }
     
    }
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        
    }

    IEnumerator LoadLevel(int levelIndex)
    {

        Fade.SetTrigger("Start");
        yield return new WaitForSeconds(tTime);
        SceneManager.LoadScene(levelIndex);   
    }
}

