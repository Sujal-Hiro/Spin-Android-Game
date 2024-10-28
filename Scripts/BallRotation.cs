using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour
{
    public float _speed = 100f;
    private void Awake()
    {
        Application.targetFrameRate = 240;
    }
    private void Update()
    {
        transform.Rotate(0, 0, _speed* Time.deltaTime);

    }
    public void changeDirection()

    {

        _speed = -_speed;

    }

}

