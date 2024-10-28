using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITween : MonoBehaviour
{
    public GameObject play;
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(play, new Vector3(.9f, .9f, .9f), 3f).setDelay(.6f).setEase(LeanTweenType.easeOutQuart);
        LeanTween.scale(particle, new Vector3(.9f, .9f, .9f), 3f).setDelay(.5f).setEase(LeanTweenType.easeOutQuart);


    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
