using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseUse : MonoBehaviour
{
    private Vector3 lastMousePosition;
    public bool isMousemoving;

    void Start()
    {
        isMousemoving = false;
        lastMousePosition = Input.mousePosition;
    }

    void FixedUpdate()
    {
        Vector3 currentMousePosition = Input.mousePosition;
        if (currentMousePosition != lastMousePosition)
        {
            isMousemoving = true;
            lastMousePosition = currentMousePosition;
        }
        else if (currentMousePosition == lastMousePosition)
        {
            isMousemoving = false;
        }
    }
}
