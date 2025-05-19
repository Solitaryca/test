using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject start, con, change, end;
    public bool isNext;

    void Start()
    {
        isNext = false;
        start.SetActive(false);
        con.SetActive(false);
        change.SetActive(false);
        end.SetActive(false);
    }

    void Update()
    {
        if (FindAnyObjectByType<EnterStart>().isMouseStart == true)
        {
            start.SetActive (true);
            con.SetActive(false);
            change.SetActive(false);
            end.SetActive(false);
        }
        if (FindAnyObjectByType<EnterCon>().isMouseCon == true)
        {
            start.SetActive(false);
            con.SetActive(true);
            change.SetActive(false);
            end.SetActive(false);
        }
        if (FindAnyObjectByType<EnterChange>().isMouseChange == true)
        {
            start.SetActive(false);
            con.SetActive(false);
            change.SetActive(true);
            end.SetActive(false);
        }
        if (FindAnyObjectByType<EnterExit>().isMouseExit == true)
        {
            start.SetActive(false);
            con.SetActive(false);
            change.SetActive(false);
            end.SetActive(true);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("1_1");
        SceneManager.LoadScene("crowscene");
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }
}
