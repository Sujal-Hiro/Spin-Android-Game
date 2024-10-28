using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public GameObject effect;
    public float duration;
    public float multiplier = 20f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            StartCoroutine(PickUp(collision));
            collision.GetComponent<Collider2D>().enabled = false;
        }

        collision.GetComponent<Collider2D>().enabled = true;
    }

    IEnumerator PickUp(Collider2D player)
    {
        Instantiate(effect, transform.position, transform.rotation);
        BallRotation speed = player.GetComponent<BallRotation>();
        speed._speed *= multiplier;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(5f);
        speed._speed /= multiplier;
        Destroy(gameObject);
    }
}
