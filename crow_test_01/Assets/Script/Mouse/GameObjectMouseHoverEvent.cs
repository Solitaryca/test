using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectMouseHoverEvent : MonoBehaviour
{
    public bool isusingMouse;

    void Start()
    {
        isusingMouse = false;
    }

    private void OnMouseOver()
    {
        isusingMouse = true;
    }

    private void OnMouseExit()
    {
        isusingMouse = false;
    }
}

