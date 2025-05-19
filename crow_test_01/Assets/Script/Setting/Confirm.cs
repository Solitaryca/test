using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Confirm : MonoBehaviour
{
    public Button yes, no;
    public GameObject y, n;
    public bool isusingKey, isusingMouse;
    public bool isNothing;

    void Start()
    {
        y.SetActive(false);
        n.SetActive(false);
        isusingKey = false;
        isusingMouse = false;
        isNothing = true;

        if (yes != null)
        {
            yes.onClick.AddListener(Delete);
        }
        if (no != null)
        {
            no.onClick.AddListener(Cancel);
        }
    }

    void Update()
    {
        CheckInputMethod();

        if (isusingKey == true)
        {
            ChangeUiByKey();
        }
        else if (isusingMouse == true)
        {
            ChangeUiByMouse();
        }

        DeByKey();
        CaByKey();
    }

    private void CheckInputMethod()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
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

    public void ChangeUiByKey()
    {
        if (isNothing == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                y.SetActive(true);
                n.SetActive(false);
                isNothing = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                y.SetActive(false);
                n.SetActive(true);
                isNothing = false;
            }
        }
        else if (isNothing == false)
        {
            if (y.activeInHierarchy)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    y.SetActive(false);
                    n.SetActive(true);
                }
            }
            else if (n.activeInHierarchy)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    y.SetActive(true);
                    n.SetActive(false);
                }
            }
        }
    }

    public void ChangeUiByMouse()
    {
        if (FindAnyObjectByType<YesDelete>().isMouseYesDe == true)
        {
            y.SetActive(true);
            n.SetActive(false);
            isNothing = false;
        }
        else if (FindAnyObjectByType<NoDelete>().isMouseNoDe == true)
        {
            y.SetActive(false);
            n.SetActive(true);
            isNothing = false;
        }
        else
        {
            y.SetActive(false);
            n.SetActive(false);
            isNothing = true;
        }
    }

    public void DeByKey()
    {
        if (y.activeInHierarchy && Input.GetKeyDown(GameManager.GM.sure))
        {
            Delete();
        }
    }

    public void CaByKey()
    {
        if (n.activeInHierarchy && Input.GetKeyDown(GameManager.GM.sure))
        {
                Cancel();
        }
    }

    public void Delete()
    {

    }

    public void Cancel()
    {
        n.SetActive(false);
        FindAnyObjectByType<NoDelete>().isMouseNoDe = false;
        FindAnyObjectByType<AToConfirm>().confirm.SetActive(false);
        FindAnyObjectByType<AToConfirm>().UnSelectAll();
        FindAnyObjectByType<Aarchive>().isOpenConfirm = false;
    }
}
