using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToFinal : MonoBehaviour
{
    public GameObject button1;

    public void MovetoFinal()
    {
        SceneManager.LoadScene("Final");
    }
}
