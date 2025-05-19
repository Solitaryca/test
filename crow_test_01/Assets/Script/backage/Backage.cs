using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Backage : MonoBehaviour
{
    public GameObject book, label_1_sel, label_1_unsel, label_2_sel, label_2_unsel, label_3_sel, label_3_unsel;
    public GameObject wuping, dangan, ditu;
    public bool isOpen;
    public bool canBackage = false;

    void Start()
    {
        isOpen = false;
        HideAllGameObjects();
        Update();
    }

    void Update()
    {
        if (canBackage==true)
        {
            if (Input.GetKeyDown(GameManager.GM.back))
            {
                ToggleUI();
            }

            if (isOpen==true)
            {
                ChangeChoice(); 
            }
        }
    }


    private void ToggleUI()
    {
        if (isOpen)
        {
            isOpen = false;
            HideAllGameObjects();
        }
        else
        {
            isOpen = true;
            SwitchToLabel1(); 
        }
    }

    public void HideAllGameObjects()
    {
        book.SetActive(false);
        label_1_sel.SetActive(false);
        label_1_unsel.SetActive(false);
        label_2_sel.SetActive(false);
        label_2_unsel.SetActive(false);
        label_3_sel.SetActive(false);
        label_3_unsel.SetActive(false);
        wuping.SetActive(false);
        dangan.SetActive(false);
        ditu.SetActive(false);
    }

    public void ChangeChoice()
    {
        if (label_1_sel.activeInHierarchy && Input.GetKeyDown(KeyCode.DownArrow))
        {
            SwitchToLabel2();
        }
        else if (label_2_sel.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                SwitchToLabel1();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                SwitchToLabel3();
            }
        }
        else if (label_3_sel.activeInHierarchy && Input.GetKeyDown(KeyCode.UpArrow))
        {
            SwitchToLabel2();
        }
    }

    private void SwitchToLabel1()
    {
        book.SetActive(true);
        label_1_sel.SetActive(true);
        label_1_unsel.SetActive(false);
        label_2_sel.SetActive(false);
        label_2_unsel.SetActive(true);
        label_3_sel.SetActive(false);
        label_3_unsel.SetActive(true);
        wuping.SetActive(true);
        dangan.SetActive(false);
        ditu.SetActive(false);
    }

    private void SwitchToLabel2()
    {
        book.SetActive(true);
        label_1_sel.SetActive(false);
        label_1_unsel.SetActive(true);
        label_2_sel.SetActive(true);
        label_2_unsel.SetActive(false);
        label_3_sel.SetActive(false);
        label_3_unsel.SetActive(true);
        wuping.SetActive(false);
        dangan.SetActive(true);
        ditu.SetActive(true);
    }

    private void SwitchToLabel3()
    {
        book.SetActive(true);
        label_1_sel.SetActive(false);
        label_1_unsel.SetActive(true);
        label_2_sel.SetActive(false);
        label_2_unsel.SetActive(true);
        label_3_sel.SetActive(true);
        label_3_unsel.SetActive(false);
        ditu.SetActive(true);
        dangan.SetActive(false);
    }
}
