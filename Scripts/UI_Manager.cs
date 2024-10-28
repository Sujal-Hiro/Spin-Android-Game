using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{

    public GameObject GameOverMenu;
    public GameObject gameOver, restart, exit;
   
    // Update is called once per frame
    public void EnableGameOverMenu()
    {
        GameOverMenu.SetActive(true);
        LeanTween.scale(gameOver, new Vector3(1.1f, 1.1f, 1.1f), 3f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveLocal(gameOver, new Vector3(0, 5, -1.19799995f), 1f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(gameOver, new Vector3(.9f, .9f, .9f), 5f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.moveLocal(restart, new Vector3(0, -47, 0), 1f).setDelay(1.7f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(exit, new Vector3(3.81469727f, -335, 0), 1f).setDelay(2f).setEase(LeanTweenType.easeOutCubic);


    }

    public void OnEnable()
    {
    
        PlayerDestroy.OnPlayerDeath += EnableGameOverMenu;
        



    }

    public void OnDisable()
    {
      
        PlayerDestroy.OnPlayerDeath -= EnableGameOverMenu;
        
       
    }
   



}

   

