using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ImageChange : MonoBehaviour
{

    public ScoreManager score;
    public Image img;
    public Sprite[] imageChange;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {


        if (score.scoreCount >= 300)
        {
            anim.SetBool("score1", true);

            anim.SetBool("score1", false);

        }



        if (score.scoreCount >= 305)
        {
            anim.SetBool("score1", false);;
            img.sprite = imageChange[0];
            anim.SetBool("score1", true);
        }



        if (score.scoreCount >= 600)
        {
            anim.SetBool("score1", true);

            anim.SetBool("score1", false);


        }



        if (score.scoreCount >= 605)
        {
            anim.SetBool("score1", false);
            img.sprite = imageChange[1];
            anim.SetBool("score1", true);
        }

        if (score.scoreCount >= 900)
        {
            anim.SetBool("score1", true);

            anim.SetBool("score1", false);


        }



        if (score.scoreCount >= 905)
        {
            anim.SetBool("score1", false);
            img.sprite = imageChange[2];
            anim.SetBool("score1", true);
        }

        if (score.scoreCount >= 1200)
        {
            anim.SetBool("score1", true);

            anim.SetBool("score1", false);


        }



        if (score.scoreCount >= 1205)
        {
            anim.SetBool("score1", false);
            img.sprite = imageChange[3];
            anim.SetBool("score1", true);
        }

        if (score.scoreCount >= 1500)
        {
            anim.SetBool("score1", true);

            anim.SetBool("score1", false);

        }



        if (score.scoreCount >= 1505)
        {
            anim.SetBool("score1", false);
            img.sprite = imageChange[4];
            anim.SetBool("score1", true);
        }



        if (score.scoreCount >= 1800)
        {
            anim.SetBool("score1", true);

            anim.SetBool("score1", false);


        }



        if (score.scoreCount >= 1805)
        {
            anim.SetBool("score1", false);
            img.sprite = imageChange[5];
            anim.SetBool("score1", true);
        }

        if (score.scoreCount >= 2100)
        {
            anim.SetBool("score1", true);

            anim.SetBool("score1", false);


        }



        if (score.scoreCount >= 2105)
        {
            anim.SetBool("score1", false);
            img.sprite = imageChange[6];
            anim.SetBool("score1", true);
        }

        if (score.scoreCount >= 2400)
        {
            anim.SetBool("score1", true);

            anim.SetBool("score1", false);


        }



        if (score.scoreCount >= 2405)
        {
            anim.SetBool("score1", false);
            img.sprite = imageChange[7];
            anim.SetBool("score1", true);
        }

        if (score.scoreCount >= 2700)
        {
            anim.SetBool("score1", true);

            anim.SetBool("score1", false);


        }



        if (score.scoreCount >= 2705)
        {
            anim.SetBool("score1", false);
            img.sprite = imageChange[8];
            anim.SetBool("score1", true);
        }

        if (score.scoreCount >= 3000)
        {
            anim.SetBool("score1", true);

            anim.SetBool("score1", false);


        }



        if (score.scoreCount >= 3005)
        {
            anim.SetBool("score1", false);
            img.sprite = imageChange[9];
            anim.SetBool("score1", true);
        }

        if (score.scoreCount >= 3300)
        {
            anim.SetBool("score1", true);

            anim.SetBool("score1", false);


        }



        if (score.scoreCount >= 3305)
        {
            anim.SetBool("score1", false);
            img.sprite = imageChange[10];
            anim.SetBool("score1", true);
        }

        if (score.scoreCount >= 3600)
        {
            anim.SetBool("score1", true);

            anim.SetBool("score1", false);


        }

        if (score.scoreCount >= 3605)
        {
            anim.SetBool("score1", false);
            img.sprite = imageChange[11];
            anim.SetBool("score1", true);
        }

    }

}