using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToStage2Result : MonoBehaviour
{
    public void moveToStage2Result()
    {
        SceneManager.LoadScene("Stage2Result");
    }
}
