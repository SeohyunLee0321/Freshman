using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoSelectStage2 : MonoBehaviour
{
    public GameObject button1;

    public void MovetoSelectStage2()
    {
        SceneManager.LoadScene("SelectStage2");
    }
}
