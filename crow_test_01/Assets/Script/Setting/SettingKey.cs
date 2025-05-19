using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class SettingKey : MonoBehaviour
{
    public List<Button> SettingButton;
    public GameObject sure, run, get, dash, back, attack, wind, sound, map, shine, reset, again;
    public Setting setting;
    public string settingName;
    public bool isusingKey;
    public bool isusingMouse;
    bool isNothing;

    void Start()
    {
        isusingKey = false;
        isusingMouse = false;

        HideAll();
    }

    void Update()
    {
        ChangeUI();
        CheckIsNothing();
        CheckInputMethod();

        if (isusingKey == true)
        {
            ChangePageByKey();
        }
        else if (isusingMouse == true) 
        {
            ShowBg();
        }
    }

    public void ChangeUI()
    {
        if (again.activeInHierarchy && FindAnyObjectByType<KeyChangeSetting>().isFinish == true)
        {
            if (Input.GetKeyDown(GameManager.GM.sure) || Input.GetMouseButtonDown(0))
            {
                HideAll();
                setting.isOpenSettingKey = false;
                setting.settingKey.SetActive(false);
                setting.setting.SetActive(true);
            }
        }
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

    public void CheckIsNothing()
    {
        if(sure.activeInHierarchy || run.activeInHierarchy || get.activeInHierarchy || dash.activeInHierarchy || back.activeInHierarchy || attack.activeInHierarchy || wind.activeInHierarchy || sound.activeInHierarchy || map.activeInHierarchy || shine.activeInHierarchy || reset.activeInHierarchy || again.activeInHierarchy)
        {
            isNothing = false;
        }
        else
        {
            isNothing = true;
        }
    }

    private void ChangePageByKey()
    {
        if (isNothing == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Page12();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Page1();
            }
        }
        else if (sure.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && FindAnyObjectByType<KeyChangeSetting>().isFinish == true)
            {
                Page12();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Page2();
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Page6();
            }
        }
        else if (run.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Page1();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Page3();
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Page7();
            }
        }
        else if (get.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Page2();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Page4();
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Page8();
            }
        }
        else if (dash.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Page3();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Page5();
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Page8();
            }
        }
        else if (back.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Page4();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && FindAnyObjectByType<KeyChangeSetting>().isFinish == true)
            {
                Page11();
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Page10();
            }
        }
        else if (attack.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Page7();
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Page1();
            }
        }
        else if (wind.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Page6();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Page8();
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Page2();
            }
        }
        else if (sound.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Page7();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Page9();
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Page3();
            }
        }
        else if (map.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Page8();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Page10();
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Page4();
            }
        }
        else if (shine.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Page9();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && FindAnyObjectByType<KeyChangeSetting>().isFinish == true)
            {
                Page11();
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Page5();
            }
        }
        else if (reset.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Page10();
            }
        }
        else if (again.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Page1();
            }
        }
    }

    private void HideAll()
    {
        sure.SetActive(false);
        run.SetActive(false);
        get.SetActive(false);
        dash.SetActive(false);
        back.SetActive(false);
        attack.SetActive(false);
        wind.SetActive(false);
        sound.SetActive(false);
        map.SetActive(false);
        shine.SetActive(false);
        reset.SetActive(false);
        again.SetActive(false);
        isNothing = true;
    }

    public void Page1()
    {
        sure.SetActive(true);
        run.SetActive(false);
        get.SetActive(false);
        dash.SetActive(false);
        back.SetActive(false);
        attack.SetActive(false);
        wind.SetActive(false);
        sound.SetActive(false);
        map.SetActive(false);
        shine.SetActive(false);
        reset.SetActive(false);
        again.SetActive(false);
    }

    public void Page2()
    {
        sure.SetActive(false);
        run.SetActive(true);
        get.SetActive(false);
        dash.SetActive(false);
        back.SetActive(false);
        attack.SetActive(false);
        wind.SetActive(false);
        sound.SetActive(false);
        map.SetActive(false);
        shine.SetActive(false);
        reset.SetActive(false);
        again.SetActive(false);
    }

    public void Page3()
    {
        sure.SetActive(false);
        run.SetActive(false);
        get.SetActive(true);
        dash.SetActive(false);
        back.SetActive(false);
        attack.SetActive(false);
        wind.SetActive(false);
        sound.SetActive(false);
        map.SetActive(false);
        shine.SetActive(false);
        reset.SetActive(false);
        again.SetActive(false);
    }

    public void Page4()
    {
        sure.SetActive(false);
        run.SetActive(false);
        get.SetActive(false);
        dash.SetActive(true);
        back.SetActive(false);
        attack.SetActive(false);
        wind.SetActive(false);
        sound.SetActive(false);
        map.SetActive(false);
        shine.SetActive(false);
        reset.SetActive(false);
        again.SetActive(false);
    }

    public void Page5()
    {
        sure.SetActive(false);
        run.SetActive(false);
        get.SetActive(false);
        dash.SetActive(false);
        back.SetActive(true);
        attack.SetActive(false);
        wind.SetActive(false);
        sound.SetActive(false);
        map.SetActive(false);
        shine.SetActive(false);
        reset.SetActive(false);
        again.SetActive(false);
    }

    public void Page6()
    {
        sure.SetActive(false);
        run.SetActive(false);
        get.SetActive(false);
        dash.SetActive(false);
        back.SetActive(false);
        attack.SetActive(true);
        wind.SetActive(false);
        sound.SetActive(false);
        map.SetActive(false);
        shine.SetActive(false);
        reset.SetActive(false);
        again.SetActive(false);
    }

    public void Page7()
    {
        sure.SetActive(false);
        run.SetActive(false);
        get.SetActive(false);
        dash.SetActive(false);
        back.SetActive(false);
        attack.SetActive(false);
        wind.SetActive(true);
        sound.SetActive(false);
        map.SetActive(false);
        shine.SetActive(false);
        reset.SetActive(false);
        again.SetActive(false);
    }

    public void Page8()
    {
        sure.SetActive(false);
        run.SetActive(false);
        get.SetActive(false);
        dash.SetActive(false);
        back.SetActive(false);
        attack.SetActive(false);
        wind.SetActive(false);
        sound.SetActive(true);
        map.SetActive(false);
        shine.SetActive(false);
        reset.SetActive(false);
        again.SetActive(false);
    }

    public void Page9()
    {
        sure.SetActive(false);
        run.SetActive(false);
        get.SetActive(false);
        dash.SetActive(false);
        back.SetActive(false);
        attack.SetActive(false);
        wind.SetActive(false);
        sound.SetActive(false);
        map.SetActive(true);
        shine.SetActive(false);
        reset.SetActive(false);
        again.SetActive(false);
    }

    public void Page10()
    {
        sure.SetActive(false);
        run.SetActive(false);
        get.SetActive(false);
        dash.SetActive(false);
        back.SetActive(false);
        attack.SetActive(false);
        wind.SetActive(false);
        sound.SetActive(false);
        map.SetActive(false);
        shine.SetActive(true);
        reset.SetActive(false);
        again.SetActive(false);
    }

    public void Page11()
    {
        sure.SetActive(false);
        run.SetActive(false);
        get.SetActive(false);
        dash.SetActive(false);
        back.SetActive(false);
        attack.SetActive(false);
        wind.SetActive(false);
        sound.SetActive(false);
        map.SetActive(false);
        shine.SetActive(false);
        reset.SetActive(true);
        again.SetActive(false);
    }

    public void Page12()
    {
        sure.SetActive(false);
        run.SetActive(false);
        get.SetActive(false);
        dash.SetActive(false);
        back.SetActive(false);
        attack.SetActive(false);
        wind.SetActive(false);
        sound.SetActive(false);
        map.SetActive(false);
        shine.SetActive(false);
        reset.SetActive(false);
        again.SetActive(true);
    }

    public void ShowBg()
    {
        switch (settingName)
        {
            case "sure":
                Page1();
                break;
            case "run":
                Page2(); 
                break;
            case "get":
                Page3(); 
                break;
            case "dash":
                Page4();
                break;
            case "back":
                Page5();
                break;
            case "attack":
                Page6(); 
                break;
            case "wind":
                Page7(); 
                break;
            case "sound":
                Page8();
                break;
            case "map":
                Page9(); 
                break;
            case "shine":
                Page10(); 
                break;
            case "reset":
                Page11();
                break;
            case "again":
                Page12();
                break;
            case null:
                HideAll();
                break;
        }
    }
}
