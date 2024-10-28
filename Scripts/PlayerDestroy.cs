using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroy : MonoBehaviour
{
    public static event Action OnPlayerDeath;
    private ScoreManager theScoreManager;
    private ParticleSystem particles;
    private SpriteRenderer sr;
    private CircleCollider2D cc;
    private TrailRenderer tr;
    public AudioSource pop;

    private void Awake()
    {

        tr = GetComponentInChildren<TrailRenderer>();
        particles = GetComponentInChildren<ParticleSystem>();
        sr = GetComponent<SpriteRenderer>();
        cc = GetComponent<CircleCollider2D>();
        theScoreManager = FindObjectOfType<ScoreManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(Destroy());
            pop.Play();
            theScoreManager.scoreIncreasing = false;
            StartCoroutine(GameOver());
            FindObjectOfType<Sounds>().GameOverMusic();
            FindObjectOfType<CoinSpawn>().StopAllCoroutines();
            FindObjectOfType<Destroy>().StopAllCoroutines();

        }

    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(1f);
        OnPlayerDeath?.Invoke();
    }

    IEnumerator Destroy()
    {
        particles.Play();
        tr.enabled = false;
        sr.enabled = false;
        cc.enabled = false;
        yield return new WaitForSeconds(particles.main.startLifetime.constantMax);
        Destroy(this.gameObject);
    }
}
