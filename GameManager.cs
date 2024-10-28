using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Animator anim;
    public Image img;
    ScoreManager scoreText;
    //[SerializeField] private float delayBeforeLoading = 10f;
    //[SerializeField] private string sceneNameToLoad;
    //private float timeElapsed; 
    private ScoreManager thescoreManager;
    public ScoreManager thescoretext;
    public GameObject Information;
    // Start is called before the first frame update
    void Start()
    {
        thescoreManager = FindObjectOfType<ScoreManager>();
        //StartCoroutine(Fade());
    }

  

    // Update is called once per frame
    void Update()
    {
        

    }


    //when player dies  
    void PlayerDies()
    {

        GameObject.FindWithTag("Reset");
        gameObject.SetActive(false);
       
    }
    public void Start_Game()
    {

        IEnumerator Fade()
        {
            anim.SetBool("FADE", true);
            yield return new WaitUntil(() => img.color.a == 1);
           
        }
        SceneManager.LoadScene(1);

    }
    public void Exit_Game()

    {
        Debug.Log("Game QUits");
        Application.Quit();
    }
    public void ResetGame()
    {

        thescoreManager.scoreIncreasing = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        thescoreManager.scoreCount = 0;
        thescoreManager.scoreIncreasing = true;
    }

    public void Enable()
    {
        LeanTween.scale(Information, new Vector3(215, 215, 215), 1f).setEase(LeanTweenType.easeOutQuart);
        Information.SetActive(true);
    }
    public void Disable()
    {
        StartCoroutine(DelayDisable());
    }

    IEnumerator DelayDisable()
    {
        LeanTween.scale(Information, new Vector3(0, 0, 0), 0.5f).setEase(LeanTweenType.easeOutQuart);
        yield return new WaitForSeconds(0.5f);
        Information.SetActive(false);
    }
}
