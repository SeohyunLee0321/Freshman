using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleUI2 : MonoBehaviour
{
    public GameObject rule;
    public GameObject score;

    void Start()
    {
        rule.SetActive(true);
        score.SetActive(false);
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rule.SetActive(false);
            score.SetActive(true);
            Time.timeScale = 1.0f;
        }
    }
}
