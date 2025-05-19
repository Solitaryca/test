using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;

public class Aarchive : MonoBehaviour
{
    public GameObject archive;
    public Button remenu;
    public Button[] archiveButtons;
    public GameObject select;
    public GameObject s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16;
    public ScrollRect scrollRect;
    public bool isOpenArchive;
    public bool isOpenConfirm;
    public bool isaved;
    public bool isusingKey, isusingMouse;
    public bool isNothing;
    public float scrollSpeed = 1.0f;

    void Start()
    {
        HideAll();
        isOpenArchive = false;
        isOpenConfirm = false;
        isaved = false;
        isusingKey = false;
        isusingMouse = false;
        isNothing = true;

        if (remenu != null)
        {
            remenu.onClick.AddListener(Reu);
        }

        for (int i = 0; i < archiveButtons.Length; i++)
        {
            if (archiveButtons[i] != null)
            {
                int index = i;
                archiveButtons[i].onClick.AddListener(() => Judge(index));
            }
        }
    }

    void Update()
    {
        if (isOpenArchive == true && isOpenConfirm == false)
        {
            CheckInputMethod();
            if (isusingKey == true)
            {
                ChangeByKey();
                ScrollByKeyDown();
            }
            else if (isusingMouse == true)
            {
                ChangeByMouse();
            }
        }
        FunctionByKey();
        scrollRect.enabled = !isOpenConfirm;
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

    private void ChangeByKey()
    {
        if (isNothing == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                P0();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                P1();
            }
        }
        else if (isNothing == false)
        {
            if (s1.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de1.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P0();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P3();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P1();
                        FindAnyObjectByType<AToConfirm>().P1();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de1.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P0();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P3();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P1();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P2();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (s2.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de2.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P0();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P4();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P1();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P2();
                        FindAnyObjectByType<AToConfirm>().P2();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de2.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P0();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P4();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P2();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (s3.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de3.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P1();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P5();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P3();
                        FindAnyObjectByType<AToConfirm>().P3();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de3.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P1();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P5();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P3();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P4();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (s4.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de4.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P2();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P6();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P3();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P4();
                        FindAnyObjectByType<AToConfirm>().P4();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de4.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P2();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P6();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P4();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (s5.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de5.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P3();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P7();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P5();
                        FindAnyObjectByType<AToConfirm>().P5();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de5.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P3();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P7();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P5();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P6();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (s6.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de6.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P4();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P8();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P5();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P6();
                        FindAnyObjectByType<AToConfirm>().P6();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de6.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P4();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P8();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P6();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (s7.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de7.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P5();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P9();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P7();
                        FindAnyObjectByType<AToConfirm>().P7();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de7.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P5();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P9();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P7();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P8();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (s8.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de8.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P6();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P10();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P7();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P8();
                        FindAnyObjectByType<AToConfirm>().P8();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de8.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P6();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P10();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P8();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (s9.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de9.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P7();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P11();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P9();
                        FindAnyObjectByType<AToConfirm>().P9();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de9.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P7();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P11();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P9();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P10();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (s10.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de10.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P8();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P12();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P9();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P10();
                        FindAnyObjectByType<AToConfirm>().P10();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de4.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P8();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P12();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P10();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (s11.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de11.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P9();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P13();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P11();
                        FindAnyObjectByType<AToConfirm>().P11();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de11.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P9();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P13();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P11();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P12();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (s12.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de12.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P10();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P14();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P11();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P12();
                        FindAnyObjectByType<AToConfirm>().P12();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de12.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P10();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P14();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P12();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (s13.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de13.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P11();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P15();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P13();
                        FindAnyObjectByType<AToConfirm>().P13();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de13.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P11();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P15();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P13();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P14();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (s14.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de14.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P12();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P16();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P13();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P14();
                        FindAnyObjectByType<AToConfirm>().P14();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de14.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P12();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        P16();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P14();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (s15.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de15.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P13();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P15();
                        FindAnyObjectByType<AToConfirm>().P15();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de15.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P13();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P15();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P16();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (s16.activeInHierarchy)
            {
                if (!FindAnyObjectByType<AToConfirm>().de16.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P14();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P15();
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        P16();
                        FindAnyObjectByType<AToConfirm>().P16();
                    }
                }
                else if (FindAnyObjectByType<AToConfirm>().de16.activeInHierarchy)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        P14();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        P16();
                        FindAnyObjectByType<AToConfirm>().UnSelectAll();
                    }
                }
            }
            else if (select.activeInHierarchy)
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    P1();
                }
            }
        }
    }

    private void ChangeByMouse()
    {
        if (FindAnyObjectByType<ReMenu>().isIn == true)
        {
            P0();
        }
        else if (FindAnyObjectByType<Pone>().isMouseOne == true)
        {
            P1();
        }
        else if (FindAnyObjectByType<Ptwo>().isMouseTwo == true)
        {
            P2();
        }
        else if (FindAnyObjectByType<Pthr>().isMouseThree == true)
        {
            P3();
        }
        else if (FindAnyObjectByType<Pfou>().isMouseFour == true)
        {
            P4();
        }
        else if (FindAnyObjectByType<Pfiv>().isMouseFive == true)
        {
            P5();
        }
        else if (FindAnyObjectByType<Psix>().isMouseSix == true)
        {
            P6();
        }
        else if (FindAnyObjectByType<Psev>().isMouseSeven == true)
        {
            P7();
        }
        else if (FindAnyObjectByType<Peig>().isMouseEight == true)
        {
            P8();
        }
        else if (FindAnyObjectByType<Pnin>().isMouseNine == true)
        {
            P9();
        }
        else if (FindAnyObjectByType<Pten>().isMouseTen == true)
        {
            P10();
        }
        else if (FindAnyObjectByType<Pele>().isMouseEleven == true)
        {
            P11();
        }
        else if (FindAnyObjectByType<Ptwe>().isMouseTwelve == true)
        {
            P12();
        }
        else if (FindAnyObjectByType<Ptht>().isMouseThirteen == true)
        {
            P13();
        }
        else if (FindAnyObjectByType<Pfot>().isMouseForteen == true)
        {
            P14();
        }
        else if (FindAnyObjectByType<Pfit>().isMouseFifteen == true)
        {
            P15();
        }
        else if (FindAnyObjectByType<Psit>().isMouseSixteen == true)
        {
            P16();
        }
        else
        {
            HideAll();
        }
    }

    public void HideAll()
    {
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(false);
        isNothing = true;
    }

    private void ScrollByKeyDown()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (!s9.activeInHierarchy && !s10.activeInHierarchy && !s11.activeInHierarchy && !s12.activeInHierarchy && !s13.activeInHierarchy && !s14.activeInHierarchy && !s15.activeInHierarchy && !s16.activeInHierarchy)
            {
                scrollRect.verticalNormalizedPosition = Mathf.Clamp(scrollRect.verticalNormalizedPosition + scrollSpeed, 0f, 1f);
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (!select.activeInHierarchy && !s1.activeInHierarchy && !s2.activeInHierarchy && !s3.activeInHierarchy && !s4.activeInHierarchy && !s5.activeInHierarchy && !s6.activeInHierarchy && !s7.activeInHierarchy && !s8.activeInHierarchy)
            {
                scrollRect.verticalNormalizedPosition = Mathf.Clamp(scrollRect.verticalNormalizedPosition - scrollSpeed, 0f, 1f);
            }
        }
    }

    public void FunctionByKey()
    {
        ReuByKey();
    }

    public void ReuByKey()
    {
        if (select.activeInHierarchy && Input.GetKeyDown(GameManager.GM.sure))
        {
            Reu();
        }
    }

    public void Reu()
    {
        if (isOpenConfirm == false)
        {
            select.SetActive(false);
            FindAnyObjectByType<ReMenu>().isIn = false;
            isNothing = true;
            isOpenArchive = false;
            archive.SetActive(false);
        }
    }

    //private string GetSaveFilePath(int index)
    //{
    //    return Application.persistentDataPath + $"/Save_{index}.json";
    //}

    public void Judge(int index)
    {
        //string filePath = GetSaveFilePath(index);
        //if (File.Exists(filePath))
        //{
        //    Load(index);
        //}
        //else
        //{
        //    Save(index);
        //}
    }

    public void Save(int index)
    {

    }

    public void Load(int index)
    {

    }

    public void P0()
    {
        isNothing = false;
        select.SetActive(true);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(false);
    }

    public void P1()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(true);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(false);
    }

    public void P2()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(true);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(false);
    }

    public void P3()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(true);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(false);
    }

    public void P4()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(true);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(false);
    }

    public void P5()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(true);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(false);
    }

    public void P6()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(true);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(false);
    }

    public void P7()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(true);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(false);
    }

    public void P8()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(true);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(false);
    }

    public void P9()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(true);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(false);
    }

    public void P10()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(true);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(false);
    }

    public void P11()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(true);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(false);
    }

    public void P12()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(true);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(false);
    }

    public void P13()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(true);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(false);
    }

    public void P14()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(true);
        s15.SetActive(false);
        s16.SetActive(false);
    }

    public void P15()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(true);
        s16.SetActive(false);
    }

    public void P16()
    {
        isNothing = false;
        select.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);
        s7.SetActive(false);
        s8.SetActive(false);
        s9.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
        s12.SetActive(false);
        s13.SetActive(false);
        s14.SetActive(false);
        s15.SetActive(false);
        s16.SetActive(true);
    }
}
