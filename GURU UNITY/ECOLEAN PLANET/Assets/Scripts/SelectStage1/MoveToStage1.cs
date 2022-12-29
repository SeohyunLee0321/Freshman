using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToStage1 : MonoBehaviour
{
    public GameObject button1;

    public void ChangeFirstStage()
    {
        SceneManager.LoadScene("Stage1");
    }
}
