using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    public static Result result;

    public int wall = 0;
    public bool success;

    void Start()
    {
        result = this;
    }

    void Update()
    {
        /*if(WallOnDamage1.wallDamage1.numBrokenWall == 1)
        {
            print("벽1 죽음");
            wall+=1;
        }*/
        
        if (WallOnDamage1.wallDamage1.numBrokenWall == 1)
        {
            print("벽1 죽음");
            wall += 1;
            WallOnDamage1.wallDamage1.numBrokenWall = 2;
        }
        
        if (WallOnDamage2.wallDamage2.numBrokenWall == 1)
        {
            print("벽2 죽음");
            wall += 1;
            WallOnDamage2.wallDamage2.numBrokenWall = 2;
        }
        
        if (WallOnDamage3.wallDamage3.numBrokenWall == 1)
        {
            print("벽3 죽음");
            wall += 1;
            WallOnDamage3.wallDamage3.numBrokenWall = 2;
        }
        
        if (WallOnDamage4.wallDamage4.numBrokenWall == 1)
        {
            print("벽4 죽음");
            wall += 1;
            WallOnDamage4.wallDamage4.numBrokenWall = 2;
        }
        
        if (WallOnDamage5.wallDamage5.numBrokenWall == 1)
        {
            print("벽5 죽음");
            wall += 1;
            WallOnDamage5.wallDamage5.numBrokenWall = 2;
        }
        

        //시간 끝
        if (Timer.timer.isEnded == true)
        {
            print(wall);
            if(wall >= 3)
            {
                success = false;
            }
            if(wall <= 2)
            {
                success = true;
            }
        }
    }
}
