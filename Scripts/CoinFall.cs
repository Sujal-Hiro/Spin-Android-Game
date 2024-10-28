using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFall : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _speed;
    private Rigidbody2D rb;
    private Vector2 screenboundary;


    private void Start()
    {

        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -_speed);
        screenboundary = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    private void Update()
    {
        if (transform.position.y < screenboundary.y * -2)
        {
            Destroy(this.gameObject);
        }
    }
}
