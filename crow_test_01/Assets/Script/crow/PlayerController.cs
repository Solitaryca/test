using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isCanControl;
    public bool isInDialog;

    private void Start()
    {
        isCanControl = false;
        isInDialog = FindAnyObjectByType<DialogController>().isDialoging;
    }

    private void Update()
    {
        if(isCanControl == true)
        {
            EnableControl();
        }
        else if (isCanControl == false)
        {
            DisableControl();
        }
        Dialog();
    }

    public void EnableControl()
    {
        CanUsingMove();
        CanUsingLight();
        CanUsingBackage();
        CanUsingMenu();
    }

    public void DisableControl()
    {
        crow_sport.instance.canMove = false;
        FindAnyObjectByType<isLighting>().canLight = false;
        FindAnyObjectByType<Backage>().canBackage = false;
        FindAnyObjectByType<OpenMenu>().isOpenMenu = false;
    }

    private void CanUsingMove()
    {
        if (FindAnyObjectByType<Backage>().isOpen == false && isInDialog == false && FindAnyObjectByType<OpenMenu>().isOpenMenu == false && FindAnyObjectByType<Setting>().isOpenSetting == false && FindAnyObjectByType<Aarchive>().isOpenArchive == false)
        {
            crow_sport.instance.canMove = true;
        }
        else if (FindAnyObjectByType<Backage>().isOpen == true || isInDialog == true || FindAnyObjectByType<OpenMenu>().isOpenMenu == true || FindAnyObjectByType<Setting>().isOpenSetting == true || FindAnyObjectByType<Aarchive>().isOpenArchive == true)
        {
            crow_sport.instance.canMove = false;
        }
    }

    private void CanUsingLight()
    {
        if (isInDialog == true || FindAnyObjectByType<OpenMenu>().isOpenMenu == true || FindAnyObjectByType<Setting>().isOpenSetting == true || FindAnyObjectByType<Aarchive>().isOpenArchive == true)
        {
            FindAnyObjectByType<isLighting>().canLight = false;
        }
        else if(isInDialog == false && FindAnyObjectByType<OpenMenu>().isOpenMenu == false && FindAnyObjectByType<Setting>().isOpenSetting == false && FindAnyObjectByType<Aarchive>().isOpenArchive == false)
        {
            FindAnyObjectByType<isLighting>().canLight = true;
        }
    }

    private void CanUsingBackage()
    {
        if (crow_sport.instance.inputX != 0 || crow_sport.instance.inputY != 0 || isInDialog == true || FindAnyObjectByType<SceneFader>().isFadeOuting==true || FindAnyObjectByType<OpenMenu>().isOpenMenu == true || FindAnyObjectByType<Setting>().isOpenSetting == true || FindAnyObjectByType<Aarchive>().isOpenArchive == true)
        {
            FindAnyObjectByType<Backage>().canBackage = false;
        }
        else if (crow_sport.instance.inputX == 0 && crow_sport.instance.inputY == 0 && isInDialog == false && FindAnyObjectByType<SceneFader>().isFadeOuting==false && FindAnyObjectByType<OpenMenu>().isOpenMenu == false && FindAnyObjectByType<Setting>().isOpenSetting == false && FindAnyObjectByType<Aarchive>().isOpenArchive == false)
        {
            FindAnyObjectByType<Backage>().canBackage = true;
        }
    }

    //private void CanUsingDialogue()
    //{
    //    if (FindAnyObjectByType<Backage>().isOpen == true || FindAnyObjectByType<OpenMenu>().isOpenMenu == true)
    //    {
    //        FindAnyObjectByType<DialogueManager>().canDialogue = false;
    //    }
    //    else if(FindAnyObjectByType<Backage>().isOpen == false && FindAnyObjectByType<OpenMenu>().isOpenMenu == false)
    //    {
    //        FindAnyObjectByType<DialogueManager>().canDialogue = true;
    //    }
    //}

    private void CanUsingMenu()
    {
        if(crow_sport.instance.inputX != 0 || crow_sport.instance.inputY != 0 || isInDialog == true || FindAnyObjectByType<SceneFader>().isFadeOuting == true || FindAnyObjectByType<Backage>().isOpen == true || FindAnyObjectByType<Setting>().isOpenSetting == true || FindAnyObjectByType<Aarchive>().isOpenArchive == true)
        {
            FindAnyObjectByType<OpenMenu>().canMenu = false;
        }
        else if(crow_sport.instance.inputX==0 && crow_sport.instance.inputY==0 && isInDialog == false && FindAnyObjectByType<SceneFader>().isFadeOuting == false && FindAnyObjectByType<Backage>().isOpen == false && FindAnyObjectByType<Setting>().isOpenSetting == false && FindAnyObjectByType<Aarchive>().isOpenArchive == false)
        {
            FindAnyObjectByType<OpenMenu>().canMenu = true;
        }
    }

    private void Dialog()
    {
        if (isInDialog == true)
        {
            isCanControl = false;
        }
        else if (isInDialog == false)
        {
            isCanControl = true;
        }
    }
}
