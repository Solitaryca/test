using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputOption : MonoBehaviour
{
    public bool isusingKey;
    public bool isusingMouse;

    void Start()
    {
        isusingKey = false;
        isusingMouse = false;
    }

    void Update()
    {
        CheckInputMethod();
    }

    private void CheckInputMethod()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            isusingKey = true;
            isusingMouse = false;
        }
        else if (FindAnyObjectByType<MouseUse>().isMousemoving == true)
        {
            isusingKey = false;
            isusingMouse = true;
        }
    }
}
