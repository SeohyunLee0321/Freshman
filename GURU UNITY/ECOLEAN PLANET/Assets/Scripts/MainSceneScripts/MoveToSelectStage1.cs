using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToSelectStage1 : MonoBehaviour
{
    public void ChangeStageSelect()
    {
        SceneManager.LoadScene("SelectStage1");
    }
}
