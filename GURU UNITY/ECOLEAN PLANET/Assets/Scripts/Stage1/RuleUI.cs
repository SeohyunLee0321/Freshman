using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleUI : MonoBehaviour
{
    public GameObject rule;

    void Start()
    {
        rule.SetActive(true);
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rule.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }
}
