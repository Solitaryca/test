using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isLighting : MonoBehaviour
{
    public GameObject myLight;
    public bool canLight = false;

    void Start()
    {
        Update();
    }

    void Update()
    {
        if (canLight == true)
        {
            if (Input.GetKeyDown(GameManager.GM.shine))
            {
                myLight.SetActive(!myLight.activeSelf);
            }
        }
    }
}

