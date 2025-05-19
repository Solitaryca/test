using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour
{
    public Image blackImage;
    [SerializeField] private float alpha;
    public bool isFadeOuting;

    private void Start()
    {
        StartCoroutine(FadeIn());
    }

    public void FadeTo(string _newSceneName)
    {
        StartCoroutine (FadeOut(_newSceneName));
    }

    IEnumerator FadeIn()
    {
        alpha = 1;
        while (alpha>0)
        {
            alpha -= Time.deltaTime;
            blackImage.color = new Color(0, 0, 0, alpha);
            yield return new WaitForSeconds(0);
        }
        FindAnyObjectByType<PlayerController>().isCanControl = true;
    }

    IEnumerator FadeOut(string sceneName)
    {
        alpha = 0;
        isFadeOuting = true;
        while (alpha<1)
        {
            alpha += Time.deltaTime;
            blackImage.color = new Color(0, 0, 0, alpha);
            yield return null;
        }
        isFadeOuting = false;
        FindAnyObjectByType<PlayerController>().isCanControl = false;
        SceneManager.LoadScene(sceneName);
    }
}
