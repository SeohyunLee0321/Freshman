using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //현재 점수 UI
    public Text CScoreUI;

    //현재 점수 기억
    public int CScore;
    [HideInInspector]
    
    //싱글톤 객체
    public static ScoreManager scoremanager = null;

    private void Awake()
    {
        if (scoremanager == null)
        {
            scoremanager = this;
        }
    }

    public int Score
    {
        get
        {
            return CScore;
        }
        set
        {
            //3. 점수 표시
            CScore = value;
            //4. 화면에 표시
            CScoreUI.text = CScore + " / 25";
        }
    }
}