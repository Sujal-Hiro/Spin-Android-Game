using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject Coin;
    public float rTime = 2.0f;
    

    private Vector2 screenboundary;
    void Start()
    {
        screenboundary = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(spawnTime());

        
    }

    // Update is called once per frame
    void SpawnCoin()
    {
        GameObject c = Instantiate(Coin) as GameObject;
        c.transform.position = new Vector2(Random.Range(-screenboundary.x / 1.4f, screenboundary.x / 1.4f), screenboundary.y * 4);
    }

    IEnumerator spawnTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(rTime);
            SpawnCoin();
        }
    }

   
}
