using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallOnDamage2 : MonoBehaviour
{
    public static WallOnDamage2 wallDamage2;
    public int numBrokenWall = 0;

    public float hp;
    public float maxHp = 20.0f;
    public GameObject brokenWall;

    public Slider hpSlider;

    void Start()
    {
        hp = maxHp;
        wallDamage2 = this;
    }


    void Update()
    {
        if (hp <= 0)
        {
            gameObject.SetActive(false);
            brokenWall.SetActive(true);

            numBrokenWall = 1;
        }

        hpSlider.value = hp / (float)maxHp;
    }

    public void wallOnDamage2(float value)
    {
        hp -= value;
        if (hp < 0)
        {
            hp = 0;
        }
    }
}
