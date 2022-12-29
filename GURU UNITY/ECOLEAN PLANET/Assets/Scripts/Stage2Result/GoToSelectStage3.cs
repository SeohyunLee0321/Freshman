using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSelectStage3 : MonoBehaviour
{
    public GameObject button1;

    public void MovetoSelectStage3()
    {
        SceneManager.LoadScene("SelectStage3");
    }
}
