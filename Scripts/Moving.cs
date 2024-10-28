using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Moving : MonoBehaviour
{

    public float enemyS = 2f;
    private Rigidbody2D rb;
    private Vector2 screenboundary;
    //public GameObject speedChange;
    //ScoreManager Change_Speed;
    private void Start()
    {
        
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(enemyS, 0);
        screenboundary = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }


    private void Update()
    {
        if (transform.position.x > screenboundary.x * 2)
        {
            Destroy(this.gameObject);
        }

    }

}