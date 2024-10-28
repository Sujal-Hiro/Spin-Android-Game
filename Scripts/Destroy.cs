using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Destroy : MonoBehaviour
{
    
    public GameObject Enemy;
    public float rTime = 6.0f;
    public float maxValue = 10.0f;
    public float minValue = 1.5f;
    float changePerSecond;
    public float timeToChange = 300.0f;


 
    private Vector2 screenboundary;
    
    void Start()
    {
        changePerSecond = (minValue - maxValue) / timeToChange;
        screenboundary = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(spawnTime());
    }

 

    private void Update()
    {
        rTime = Mathf.Clamp(rTime + changePerSecond * Time.deltaTime, minValue, maxValue);
    }



    private void spawnEnemy()
    {
        
        GameObject e = Instantiate(Enemy) as GameObject;
        e.transform.position = new Vector2(screenboundary.x * -2, Random.Range(-screenboundary.y / 1.8f, screenboundary.y / 3.8f));
    }
    IEnumerator spawnTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(rTime);
            spawnEnemy();
        }

    }

  


}



