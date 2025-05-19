using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AToConfirm : MonoBehaviour
{
    public Button d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16;
    public GameObject de1, de2, de3, de4, de5, de6, de7, de8, de9, de10, de11, de12, de13, de14, de15, de16;
    public GameObject confirm;

    void Start()
    {
        confirm.SetActive(false);
        UnSelectAll();

        if (d1 != null)
        {
            d1.onClick.AddListener(AtoC);
        }
        if (d2 != null)
        {
            d2.onClick.AddListener(AtoC);
        }
        if (d3 != null)
        {
            d3.onClick.AddListener(AtoC);
        }
        if (d4 != null)
        {
            d4.onClick.AddListener(AtoC);
        }
        if (d5 != null)
        {
            d5.onClick.AddListener(AtoC);
        }
        if (d6 != null)
        {
            d6.onClick.AddListener(AtoC);
        }
        if (d7 != null)
        {
            d7.onClick.AddListener(AtoC);
        }
        if (d8 != null)
        {
            d8.onClick.AddListener(AtoC);
        }
        if (d9 != null)
        {
            d9.onClick.AddListener(AtoC);
        }
        if (d10 != null)
        {
            d10.onClick.AddListener(AtoC);
        }
        if (d11 != null)
        {
            d11.onClick.AddListener(AtoC);
        }
        if (d12 != null)
        {
            d12.onClick.AddListener(AtoC);
        }
        if (d13 != null)
        {
            d13.onClick.AddListener(AtoC);
        }
        if (d14 != null)
        {
            d14.onClick.AddListener(AtoC);
        }
        if (d15 != null)
        {
            d15.onClick.AddListener(AtoC);
        }
        if (d16 != null)
        {
            d16.onClick.AddListener(AtoC);
        }
    }

    void Update()
    {
        AtoCByKey();

        if (FindAnyObjectByType<Aarchive>().isOpenConfirm == false)
        {
            if (FindAnyObjectByType<Aarchive>().isusingKey == false && FindAnyObjectByType<Aarchive>().isusingMouse == true)
            {
                ChangeUIByMouse();
            }  
        }
    }

    public void ChangeUIByMouse()
    {
        if (FindAnyObjectByType<D1>().isMouseDe1 == true)
        {
            P1();
        }
        else if (FindAnyObjectByType<D2>().isMouseDe2 == true)
        {
            P2();
        }
        else if (FindAnyObjectByType<D3>().isMouseDe3 == true)
        {
            P3();
        }
        else if (FindAnyObjectByType<D4>().isMouseDe4 == true)
        {
            P4();
        }
        else if (FindAnyObjectByType<D5>().isMouseDe5 == true)
        {
            P5();
        }
        else if (FindAnyObjectByType<D6>().isMouseDe6 == true)
        {
            P6();
        }
        else if (FindAnyObjectByType<D7>().isMouseDe7 == true)
        {
            P7();
        }
        else if (FindAnyObjectByType<D8>().isMouseDe8 == true)
        {
            P8();
        }
        else if (FindAnyObjectByType<D9>().isMouseDe9 == true)
        {
            P9();
        }
        else if (FindAnyObjectByType<D10>().isMouseDe10 == true)
        {
            P10();
        }
        else if (FindAnyObjectByType<D11>().isMouseDe11 == true)
        {
            P11();
        }
        else if (FindAnyObjectByType<D12>().isMouseDe12 == true)
        {
            P12();
        }
        else if (FindAnyObjectByType<D13>().isMouseDe13 == true)
        {
            P13();
        }
        else if (FindAnyObjectByType<D14>().isMouseDe14 == true)
        {
            P14();
        }
        else if (FindAnyObjectByType<D15>().isMouseDe15 == true)
        {
            P15();
        }
        else if (FindAnyObjectByType<D16>().isMouseDe16 == true)
        {
            P16();
        }
        else
        {
            UnSelectAll();
        }
    }

    public void UnSelectAll()
    {
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(false);
        de6.SetActive(false);
        de7.SetActive(false);
        de8.SetActive(false);
        de9.SetActive(false);
        de10.SetActive(false);
        de11.SetActive(false);
        de12.SetActive(false);
        de13.SetActive(false);
        de14.SetActive(false);
        de15.SetActive(false);
        de16.SetActive(false);
    }

    public void P1()
    {
        de1.SetActive(true);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(false);
        de6.SetActive(false);
        de7.SetActive(false);
        de8.SetActive(false);
        de9.SetActive(false);
        de10.SetActive(false);
        de11.SetActive(false);
        de12.SetActive(false);
        de13.SetActive(false);
        de14.SetActive(false);
        de15.SetActive(false);
        de16.SetActive(false);
    }

    public void P2()
    {
        de1.SetActive(false);
        de2.SetActive(true);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(false);
        de6.SetActive(false);
        de7.SetActive(false);
        de8.SetActive(false);
        de9.SetActive(false);
        de10.SetActive(false);
        de11.SetActive(false);
        de12.SetActive(false);
        de13.SetActive(false);
        de14.SetActive(false);
        de15.SetActive(false);
        de16.SetActive(false);
    }

    public void P3()
    {
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(true);
        de4.SetActive(false);
        de5.SetActive(false);
        de6.SetActive(false);
        de7.SetActive(false);
        de8.SetActive(false);
        de9.SetActive(false);
        de10.SetActive(false);
        de11.SetActive(false);
        de12.SetActive(false);
        de13.SetActive(false);
        de14.SetActive(false);
        de15.SetActive(false);
        de16.SetActive(false);
    }

    public void P4()
    {
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(true);
        de5.SetActive(false);
        de6.SetActive(false);
        de7.SetActive(false);
        de8.SetActive(false);
        de9.SetActive(false);
        de10.SetActive(false);
        de11.SetActive(false);
        de12.SetActive(false);
        de13.SetActive(false);
        de14.SetActive(false);
        de15.SetActive(false);
        de16.SetActive(false);
    }

    public void P5()
    {
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(true);
        de6.SetActive(false);
        de7.SetActive(false);
        de8.SetActive(false);
        de9.SetActive(false);
        de10.SetActive(false);
        de11.SetActive(false);
        de12.SetActive(false);
        de13.SetActive(false);
        de14.SetActive(false);
        de15.SetActive(false);
        de16.SetActive(false);
    }

    public void P6()
    {
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(false);
        de6.SetActive(true);
        de7.SetActive(false);
        de8.SetActive(false);
        de9.SetActive(false);
        de10.SetActive(false);
        de11.SetActive(false);
        de12.SetActive(false);
        de13.SetActive(false);
        de14.SetActive(false);
        de15.SetActive(false);
        de16.SetActive(false);
    }

    public void P7()
    {
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(false);
        de6.SetActive(false);
        de7.SetActive(true);
        de8.SetActive(false);
        de9.SetActive(false);
        de10.SetActive(false);
        de11.SetActive(false);
        de12.SetActive(false);
        de13.SetActive(false);
        de14.SetActive(false);
        de15.SetActive(false);
        de16.SetActive(false);
    }

    public void P8()
    {
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(false);
        de6.SetActive(false);
        de7.SetActive(false);
        de8.SetActive(true);
        de9.SetActive(false);
        de10.SetActive(false);
        de11.SetActive(false);
        de12.SetActive(false);
        de13.SetActive(false);
        de14.SetActive(false);
        de15.SetActive(false);
        de16.SetActive(false);
    }

    public void P9()
    {
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(false);
        de6.SetActive(false);
        de7.SetActive(false);
        de8.SetActive(false);
        de9.SetActive(true);
        de10.SetActive(false);
        de11.SetActive(false);
        de12.SetActive(false);
        de13.SetActive(false);
        de14.SetActive(false);
        de15.SetActive(false);
        de16.SetActive(false);
    }

    public void P10()
    {
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(false);
        de6.SetActive(false);
        de7.SetActive(false);
        de8.SetActive(false);
        de9.SetActive(false);
        de10.SetActive(true);
        de11.SetActive(false);
        de12.SetActive(false);
        de13.SetActive(false);
        de14.SetActive(false);
        de15.SetActive(false);
        de16.SetActive(false);
    }

    public void P11()
    {
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(false);
        de6.SetActive(false);
        de7.SetActive(false);
        de8.SetActive(false);
        de9.SetActive(false);
        de10.SetActive(false);
        de11.SetActive(true);
        de12.SetActive(false);
        de13.SetActive(false);
        de14.SetActive(false);
        de15.SetActive(false);
        de16.SetActive(false);
    }

    public void P12()
    {
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(false);
        de6.SetActive(false);
        de7.SetActive(false);
        de8.SetActive(false);
        de9.SetActive(false);
        de10.SetActive(false);
        de11.SetActive(false);
        de12.SetActive(true);
        de13.SetActive(false);
        de14.SetActive(false);
        de15.SetActive(false);
        de16.SetActive(false);
    }

    public void P13()
    {
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(false);
        de6.SetActive(false);
        de7.SetActive(false);
        de8.SetActive(false);
        de9.SetActive(false);
        de10.SetActive(false);
        de11.SetActive(false);
        de12.SetActive(false);
        de13.SetActive(true);
        de14.SetActive(false);
        de15.SetActive(false);
        de16.SetActive(false);
    }

    public void P14()
    {
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(false);
        de6.SetActive(false);
        de7.SetActive(false);
        de8.SetActive(false);
        de9.SetActive(false);
        de10.SetActive(false);
        de11.SetActive(false);
        de12.SetActive(false);
        de13.SetActive(false);
        de14.SetActive(true);
        de15.SetActive(false);
        de16.SetActive(false);
    }

    public void P15()
    {
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(false);
        de6.SetActive(false);
        de7.SetActive(false);
        de8.SetActive(false);
        de9.SetActive(false);
        de10.SetActive(false);
        de11.SetActive(false);
        de12.SetActive(false);
        de13.SetActive(false);
        de14.SetActive(false);
        de15.SetActive(true);
        de16.SetActive(false);
    }

    public void P16()
    {
        de1.SetActive(false);
        de2.SetActive(false);
        de3.SetActive(false);
        de4.SetActive(false);
        de5.SetActive(false);
        de6.SetActive(false);
        de7.SetActive(false);
        de8.SetActive(false);
        de9.SetActive(false);
        de10.SetActive(false);
        de11.SetActive(false);
        de12.SetActive(false);
        de13.SetActive(false);
        de14.SetActive(false);
        de15.SetActive(false);
        de16.SetActive(true);
    }

    public void AtoCByKey()
    {
        if (de1.activeInHierarchy || de2.activeInHierarchy || de3.activeInHierarchy || de4.activeInHierarchy || de5.activeInHierarchy || de6.activeInHierarchy || de7.activeInHierarchy || de8.activeInHierarchy || de9.activeInHierarchy || de10.activeInHierarchy || de11.activeInHierarchy || de12.activeInHierarchy || de13.activeInHierarchy || de14.activeInHierarchy || de15.activeInHierarchy || de16.activeInHierarchy)
        {
            if (Input.GetKeyDown(GameManager.GM.sure))
            {
                AtoC();
            }
        }
    }

    public void AtoC()
    {
        if(FindAnyObjectByType<Aarchive>().isOpenConfirm == false)
        {
            confirm.SetActive(true);
            FindAnyObjectByType<Aarchive>().isOpenConfirm = true;
        }
    }
}
