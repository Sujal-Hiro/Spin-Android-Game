using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;

public class CoinPickUp : MonoBehaviour
{
    public float coin = 0;
    public Text coinText;
    public AudioSource coinAudio;
    public GameObject coinObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            coin++;
            coinText.text = coin.ToString();
            CoinUi();
            Destroy(collision.gameObject);
            CameraShaker.Instance.ShakeOnce(.5f ,2f, .1f, 1f);
            
            coinAudio.Play();
        }
    }

    private void CoinUi()
    {
        LeanTween.scale(coinObject, new Vector3(1.2f, 1.2f, 1.2f), 1f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
        coinObject.transform.localScale = new Vector3(1f,1f,1f);
    }
}
