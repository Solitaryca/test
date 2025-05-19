using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class SettingMusic : MonoBehaviour
{
    public bool isNothing;
    public GameObject re;
    public Button ret;
    private bool isusingKey;
    private bool isusingMouse;

    void Start()
    {
        re.SetActive(false);
        isNothing = true;
        isusingKey = false;
        isusingMouse = false;

        if (ret != null)
        {
            ret.onClick.AddListener(Ret);
        }
    }

    void Update()
    {
        ChangeWay();
        Retu();

        if(FindAnyObjectByType<Setting>().settingMusic == true)
        {
            if (isusingKey == true)
            {
                ChangeReturnKey();
            }
            else if (isusingMouse == true)
            {
                ChangeReturnMouse();
            }
        }
    }

    public void ChangeWay()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
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

    public void ChangeReturnMouse()
    {
        if(FindAnyObjectByType<M1>().isMouseM1 == true)
        {
            re.SetActive(true);
            isNothing = false;
        }
        else if(FindAnyObjectByType<M1>().isMouseM1 == false)
        {
            re.SetActive(false);
            isNothing = true;
        }
    }

    public void ChangeReturnKey()
    {
        if(isNothing == true)
        {
            if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                re.SetActive(true);
                isNothing = false;
            }
        }
    }

    public void Ret()
    {
        re.SetActive(false);
        isNothing = true;
        FindAnyObjectByType<M1>().isMouseM1 = false;
        FindAnyObjectByType<Setting>().isOpenSettingMusic = false;
        FindAnyObjectByType<Setting>().settingMusic.SetActive(false);
        FindAnyObjectByType<Setting>().setting.SetActive(true);
    }

    public void Retu()
    {
        if (re.activeInHierarchy)
        {
            if (Input.GetKeyDown(GameManager.GM.sure))
            {
                re.SetActive(false);
                isNothing = true;
                FindAnyObjectByType<M1>().isMouseM1 = false;
                FindAnyObjectByType<Setting>().isOpenSettingMusic = false;
                FindAnyObjectByType<Setting>().settingMusic.SetActive(false);
                FindAnyObjectByType<Setting>().setting.SetActive(true);
            }
        }
    }
}
