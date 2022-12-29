using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovetoStage2 : MonoBehaviour
{
    public GameObject button1;

    public void ChangeSecondStage()
    {
        SceneManager.LoadScene("Stage2");
    }
}
