using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public GameObject targetObject; 
    public bool canMouse;

    private void Start()
    {
        canMouse = false;
    }

    private void Update()
    {
        if (targetObject!=null && targetObject.activeInHierarchy)
        {
            canMouse = true;
            MouseState();
        }
        else if(!targetObject.activeInHierarchy)
        {
            canMouse = false;
            MouseState();
        }
    }

    private void MouseState()
    {
        if(canMouse == true)
        {
            ShowMouse();
        }
        else if(canMouse == false)
        {
            HideMouse();
        }
    }

    public void ShowMouse()
    {
        Cursor.visible = true; 
        Cursor.lockState = CursorLockMode.None; 
    }

    public void HideMouse()
    {
        Cursor.visible = false; 
        Cursor.lockState = CursorLockMode.Locked; 
    }
}

