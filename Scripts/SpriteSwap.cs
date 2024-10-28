using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwap : MonoBehaviour
{
    public List<Sprite> spritesToSwap; // contains all the sprites to loop through
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwapSprites());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    IEnumerator SwapSprites()
    {
        int spriteIndex = 0;
        while (true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spritesToSwap[spriteIndex];
            // ^ replace the sprite
            spriteIndex++;
            if (spriteIndex == spritesToSwap.Count) spriteIndex = 0;
            // ^ loop back to first sprite
            yield return new WaitForSeconds(30f); // adjust this time as desired
        }
    }
}
