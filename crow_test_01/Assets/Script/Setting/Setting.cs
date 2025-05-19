using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    public GameObject setting;
    public GameObject music, key, remain;
    public GameObject sele_1, sele_2, sele_3;
    public GameObject settingKey, settingMusic;
    public bool isOpenSetting;
    public bool isOpenSettingKey, isOpenSettingMusic;
    private bool isusingKey;
    private bool isusingMouse;
    bool isNothing;

    void Start()
    {
        isOpenSetting = false;
        isOpenSettingKey = false;
        isOpenSettingMusic = false;
        settingKey.SetActive(false);
        settingMusic.SetActive(false);
        isusingKey = false;
        isusingMouse = false;
        SwitchToPage0();
    }

    void Update()
    {
        JumpInterface();

        if (setting.activeInHierarchy)
        {
            CheckInputMethod();

            if (isusingKey == true)
            {
                ChangePageByKey();
            }
            else if (isusingMouse == true)
            {
                ChangePageByMouse();
            }
        }
    }

    private void CheckInputMethod()
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

    private void ChangePageByKey()
    {
        if (isNothing == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                SwitchToPage1();
            }
        }
        else if (sele_1.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                SwitchToPage2();
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                SwitchToPage3();
            }

        }
        else if (sele_2.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                SwitchToPage1();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                SwitchToPage3();
            }
        }
        else if (sele_3.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                SwitchToPage2();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                SwitchToPage1();
            }
        }
    }

    private void ChangePageByMouse()
    {
        if (FindAnyObjectByType<T1>().isMouseT1 == true)
        {
            SwitchToPage1();
        }
        else if (FindAnyObjectByType<T2>().isMouseT2 == true)
        {
            SwitchToPage2();
        }
        else if (FindAnyObjectByType<T3>().isMouseT3 == true)
        {
            SwitchToPage3();
        }
        else
        {
            SwitchToPage0();
        }
    }

    public void JumpInterface()
    {
        if (sele_1.activeInHierarchy)
        {
            if(Input.GetKeyDown(GameManager.GM.sure) || Input.GetMouseButtonDown(0))
            {
                setting.SetActive(false);
                settingMusic.SetActive(true);
                isOpenSettingMusic = true;
            }
        }
        else if (sele_2.activeInHierarchy)
        {
            if(Input.GetKeyDown(GameManager.GM.sure) || Input.GetMouseButtonDown(0))
            {
                setting.SetActive(false);
                settingKey.SetActive(true);
                isOpenSettingKey = true;
            }
        }
        else if (sele_3.activeInHierarchy)
        {
            if(Input.GetKeyDown(GameManager.GM.sure) || Input.GetMouseButtonDown(0))
            {
                SwitchToPage0();
                FindAnyObjectByType<T3>().isMouseT3 = false;
                isOpenSetting = false;
                setting.SetActive(false);
            }
        }
    }

    private void SwitchToPage0()
    {
        sele_1.SetActive(false);
        sele_2.SetActive(false);
        sele_3.SetActive(false);
        isNothing = true;
    }

    private void SwitchToPage1()
    {
        sele_1.SetActive(true);
        sele_2.SetActive(false);
        sele_3.SetActive(false);
        isNothing = false;
    }

    private void SwitchToPage2()
    {
        sele_1.SetActive(false);
        sele_2.SetActive(true);
        sele_3.SetActive(false);
        isNothing = false;
    }

    private void SwitchToPage3()
    {
        sele_1.SetActive(false);
        sele_2.SetActive(false);
        sele_3.SetActive(true);
        isNothing = false;
    }
}
