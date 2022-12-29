using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToStage1Result : MonoBehaviour
{
    public void moveToStage1Result()
    {
        SceneManager.LoadScene("Stage1Result");
    }
}
