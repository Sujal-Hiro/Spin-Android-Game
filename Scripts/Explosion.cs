using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private Transform _player;
    
   

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
       
        StoreLocalPositon();

    }

    void Update()
    {
        StoreLocalPositon();
        
        
    }

    void StoreLocalPositon()
    {
        
            transform.position = new Vector2(_player.transform.position.x, _player.transform.position.y);

        
    }

   
}
