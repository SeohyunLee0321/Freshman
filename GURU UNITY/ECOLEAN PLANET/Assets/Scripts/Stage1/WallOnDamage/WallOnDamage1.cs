using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallOnDamage1 : MonoBehaviour
{
    public static WallOnDamage1 wallDamage1;

    public float hp = 1;
    public float maxHp = 20.0f;
    public GameObject brokenWall;
    public int numBrokenWall = 0;

    public Slider hpSlider;

    AudioSource aSource;

    void Start()
    {
        hp = maxHp;
        wallDamage1 = this;

        //aSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if(hp <= 0)
        {
            gameObject.SetActive(false);
            brokenWall.SetActive(true);

            /*aSource = GetComponent<AudioSource>();
            aSource.Play();*/

            numBrokenWall = 1;
        }

        hpSlider.value = hp / (float)maxHp;
    }
    
    public void wallOnDamage1(float value)
    {
        hp -= value;
        if(hp < 0)
        {
            hp = 0;
        }
    }
}
