using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{
    public GameObject Menu, black;
    GameObject archive, setting;
    public GameObject sele_1, sele_2, sele_3, sele_4;
    public bool isOpenMenu;
    private bool isusingKey;
    private bool isusingMouse;
    public bool canMenu = false;
    bool isNothing;
    public GameObject dontDestroyObject;

    private void Start()
    {
        isNothing = true;
        isOpenMenu = false;
        isusingKey = false;
        isusingMouse = false;
        archive = FindAnyObjectByType<Aarchive>().archive;
        setting = FindAnyObjectByType<Setting>().setting;
        HideALL();
    }

    private void Update()
    {
        CheckInputMethod();
        Black();

        if (canMenu == true)
        {
            if (isOpenMenu == false && Input.GetKeyDown(KeyCode.Escape))
            {
                isOpenMenu = true;
                SwitchToPage0();
            }
            else if(isOpenMenu == true && sele_1.activeInHierarchy)
            {
                if(Input.GetKeyDown(GameManager.GM.sure) || Input.GetMouseButtonDown(0))
                {
                    isOpenMenu = false;
                    FindAnyObjectByType<IsMouseEnterA>().isMouseA = false;
                    HideALL();
                }
            }
            else if (isOpenMenu == true && sele_2.activeInHierarchy)
            {
                if (Input.GetKeyDown(GameManager.GM.sure) || Input.GetMouseButtonDown(0))
                {
                    archive.SetActive(true);
                    FindAnyObjectByType<Aarchive>().isOpenArchive = true;
                }
            }
            else if(isOpenMenu == true && sele_3.activeInHierarchy)
            {
                if (Input.GetKeyDown(GameManager.GM.sure) || Input.GetMouseButtonDown(0))
                {
                    setting.SetActive(true);
                    FindAnyObjectByType<Setting>().isOpenSetting = true;
                }
            }
            else if(isOpenMenu == true && sele_4.activeInHierarchy)
            {
                if (Input.GetKeyDown(GameManager.GM.sure) || Input.GetMouseButtonDown(0))
                {
                    isOpenMenu = false;
                    FindAnyObjectByType<IsMouseEnterD>().isMouseD = false;
                    HideALL();

                    if (dontDestroyObject != null)
                    {
                        Destroy(dontDestroyObject);  
                    }
                    SceneManager.LoadScene("main");
                }
            }

            if (isOpenMenu == true)
            {
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
    }

    private void CheckInputMethod()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
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

    private void HideALL()
    {
        Menu.SetActive(false);
        black.SetActive(false);
        sele_1.SetActive(false);
        sele_2.SetActive(false);
        sele_3.SetActive(false);
        sele_4.SetActive(false);
    }

    private void ChangePageByKey()
    {
        if (isNothing == true)
        {
            if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                SwitchToPage1();
            }
        }
        else if (sele_1.activeInHierarchy)
        {
            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                SwitchToPage2();                
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                SwitchToPage4();
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
                SwitchToPage4();
            }
        }
        else if (sele_4.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                SwitchToPage3();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                SwitchToPage1();
            }
        }
    }

    private void ChangePageByMouse()
    {
        if (FindAnyObjectByType<IsMouseEnterA>().isMouseA == true)
        {
            SwitchToPage1();
        }
        else if (FindAnyObjectByType<IsMouseEnterB>().isMouseB == true)
        {
            SwitchToPage2();
        }
        else if (FindAnyObjectByType<IsMouseEnterC>().isMouseC == true)
        {
            SwitchToPage3();
        }
        else if (FindAnyObjectByType<IsMouseEnterD>().isMouseD == true)
        {
            SwitchToPage4();
        }
        else
        {
            SwitchToPage0();
        }
    }

    public void Black()
    {
        if(FindAnyObjectByType<Setting>().isOpenSetting == true || FindAnyObjectByType<Aarchive>().isOpenArchive == true)
        {
            black.SetActive(false);
        }
        else if (FindAnyObjectByType<Setting>().isOpenSetting == false && FindAnyObjectByType<Aarchive>().isOpenArchive == false)
        {
            black.SetActive(true);
        }
    }

    private void SwitchToPage0()
    {
        Menu.SetActive(true);
        sele_1.SetActive(false);
        sele_2.SetActive(false);
        sele_3.SetActive(false);
        sele_4.SetActive(false);
        isNothing = true;
    }

    private void SwitchToPage1()
    {
        Menu.SetActive(true);
        sele_1.SetActive(true);
        sele_2.SetActive(false);
        sele_3.SetActive(false);
        sele_4.SetActive(false);
        isNothing = false;
    }

    private void SwitchToPage2()
    {
        Menu.SetActive(true);
        sele_1.SetActive(false);
        sele_2.SetActive(true);
        sele_3.SetActive(false);
        sele_4.SetActive(false);
        isNothing = false;
    }

    private void SwitchToPage3()
    {
        Menu.SetActive(true);
        sele_1.SetActive(false);
        sele_2.SetActive(false);
        sele_3.SetActive(true);
        sele_4.SetActive(false);
        isNothing = false;
    }

    private void SwitchToPage4()
    {
        Menu.SetActive(true);
        sele_1.SetActive(false);
        sele_2.SetActive(false);
        sele_3.SetActive(false);
        sele_4.SetActive(true);
        isNothing = false;
    }
}

