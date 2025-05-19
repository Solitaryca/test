using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button startButton, conButton, chanButton, endButton;
    public GameObject start, con, change, end;
    private bool isusingKey;
    private bool isusingMouse;
    public bool isAllow;
    public bool isNothing;
    public bool isNext;

    void Start()
    {
        isAllow = true;
        isNext = false;
        isusingKey = false;
        isusingMouse = false;
        isNothing = true;
        start.SetActive(false);
        con.SetActive(false);
        change.SetActive(false);
        end.SetActive(false);
        FindAnyObjectByType<Setting>().setting.SetActive(false);
        FindAnyObjectByType<Aarchive>().archive.SetActive(false);
        FindAnyObjectByType<Setting>().isOpenSetting = false;
        FindAnyObjectByType<Aarchive>().isOpenArchive = false;

        if (startButton != null)
        {
            startButton.onClick.AddListener(StartGame);
        }
        if (conButton != null)
        {
            conButton.onClick.AddListener(ContinueGame);
        }
        if (chanButton != null)
        {
            chanButton.onClick.AddListener(ChangeSetting);
        }
        if (endButton != null)
        {
            endButton.onClick.AddListener(ExitGame);
        }
    }

    void Update()
    {
        if (isAllow == true)
        {
            CheckInputMethod();
            NextByKey();

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

    public void FixedUpdate()
    {
        IsAllow();
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
                P1();
            }
        }
        else if (start.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                P2();
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                P4();
            }

        }
        else if (con.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                P1();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                P3();
            }
        }
        else if (change.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                P2();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                P4();
            }
        }
        else if (end.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                P3();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                P1();
            }
        }
    }

    private void ChangePageByMouse()
    {
        if (FindAnyObjectByType<EnterStart>().isMouseStart == true)
        {
            P1();
        }
        else if (FindAnyObjectByType<EnterCon>().isMouseCon == true)
        {
            P2();
        }
        else if(FindAnyObjectByType<EnterChange>().isMouseChange == true)
        {
            P3();
        }
        else if(FindAnyObjectByType<EnterExit>().isMouseExit == true)
        {
            P4();
        }
        else
        {
            P0();
        }
    }

    public void IsAllow()
    {
        if (FindAnyObjectByType<Aarchive>().isOpenArchive == true || FindAnyObjectByType<Setting>().isOpenSetting == true)
        {
            isAllow = false;
        }
        else if (FindAnyObjectByType<Aarchive>().isOpenArchive == false && FindAnyObjectByType<Setting>().isOpenSetting == false)
        {
            isAllow = true;
        }
    }

    public void NextByKey()
    {
        if (start.activeInHierarchy && Input.GetKeyDown(GameManager.GM.sure))
        {
            StartGame();
        }
        else if (con.activeInHierarchy && Input.GetKeyDown(GameManager.GM.sure))
        {
            ContinueGame();
        }
        else if (change.activeInHierarchy && Input.GetKeyDown(GameManager.GM.sure))
        {
            ChangeSetting();
        }
        else if (end.activeInHierarchy && Input.GetKeyDown(GameManager.GM.sure))
        {
            ExitGame();
        }
    }

    void StartGame()
    {
        isNext = true;
        start.SetActive(false);
        FindAnyObjectByType<EnterStart>().isMouseStart = false;
        StartCoroutine(WaitForSecondsCoroutine());
        if (FindAnyObjectByType<FadeToBlack>().isFade == false)
        {
            SceneManager.LoadScene("1_1");
            SceneManager.LoadScene("crow", LoadSceneMode.Additive);
        }
    }

    void ContinueGame()
    {
        FindAnyObjectByType<Aarchive>().archive.SetActive(true);
        FindAnyObjectByType<Aarchive>().isOpenArchive = true;
    }

    void ChangeSetting()
    {
        FindAnyObjectByType<Setting>().setting.SetActive(true);
        FindAnyObjectByType<Setting>().isOpenSetting = true;
    }

    void ExitGame()
    {
        Application.Quit();
        //#if UNITY_EDITOR
        //        UnityEditor.EditorApplication.isPlaying = false;
        //#else
        //        Application.Quit();
        //#endif
    }

    IEnumerator WaitForSecondsCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
    }

    public void P0()
    {
        isNothing = true;
        start.SetActive(false);
        con.SetActive(false);
        change.SetActive(false);
        end.SetActive(false);
    }

    public void P1()
    {
        isNothing = false;
        start.SetActive(true);
        con.SetActive(false);
        change.SetActive(false);
        end.SetActive(false);
    }

    public void P2()
    {
        isNothing = false;
        start.SetActive(false);
        con.SetActive(true);
        change.SetActive(false);
        end.SetActive(false);
    }

    public void P3()
    {
        isNothing = false;
        start.SetActive(false);
        con.SetActive(false);
        change.SetActive(true);
        end.SetActive(false);
    }

    public void P4()
    {
        isNothing = false;
        start.SetActive(false);
        con.SetActive(false);
        change.SetActive(false);
        end.SetActive(true);
    }
}
