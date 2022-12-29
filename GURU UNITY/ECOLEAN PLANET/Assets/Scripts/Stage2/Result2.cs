using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result2 : MonoBehaviour
{
    public static Result2 result2;

    public bool success;

    void Start()
    {
        result2 = this;
    }

    void Update()
    {
        if(PlayerMove2.move2.Hp > 0)
        {
            if (ScoreManager.scoremanager.CScore == 25 || PlayerMove2.move2.Hp == 0)//게임 종료 시점
            {
                if (ScoreManager.scoremanager.CScore == 25)
                {
                    success = true;
                }
                if (PlayerMove2.move2.Hp == 0)
                {
                    success = false;
                }
            }
        }
    }
}
