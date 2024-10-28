using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Information : MonoBehaviour
{
    public GameObject Info;
    // Start is called before the first frame update
    void Start()
    {
       
        
           LeanTween.scale(Info, new Vector3(215, 215, 215), 2f).setDelay(0.5f).setEase(LeanTweenType.easeOutQuart);
            Info.SetActive(true);
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
