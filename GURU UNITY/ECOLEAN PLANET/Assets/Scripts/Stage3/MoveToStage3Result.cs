using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToStage3Result : MonoBehaviour
{
    public void moveToStage3Result()
    {
        SceneManager.LoadScene("Stage3Result");
    }
}
