using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleUI3 : MonoBehaviour
{
    public GameObject rule;

    void Start()
    {
        rule.SetActive(true);
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            rule.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }
}
