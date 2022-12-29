using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToStage3 : MonoBehaviour
{
    public GameObject button1;

    public void ChangeThirdStage()
    {
        SceneManager.LoadScene("Stage3");
    }
}
