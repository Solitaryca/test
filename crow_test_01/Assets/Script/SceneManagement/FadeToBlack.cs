using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeToBlack : MonoBehaviour
{
    public Image fadeImage;  
    public float fadeDuration = 10f; 
    public bool isFade;

    void Start()
    {
        isFade = false;
        fadeImage.color = new Color(0, 0, 0, 0);
    }

    public void Update()
    {
        if(FindAnyObjectByType<MainMenuController>().isNext==true && isFade == false)
        {
            isFade = true;
            StartFadeIn();
        }
    }

    public void StartFadeIn()
    {
        StartCoroutine(FadeInCoroutine());
    }

    public void StartFadeOut()
    {
        StartCoroutine(FadeOutCoroutine());
    }

    private IEnumerator FadeInCoroutine()
    {
        float timeElapsed = 0f;
        Color initialColor = fadeImage.color;

        while (timeElapsed < fadeDuration)
        {
            fadeImage.color = Color.Lerp(initialColor, new Color(0, 0, 0, 1), timeElapsed / fadeDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }

        fadeImage.color = new Color(0, 0, 0, 1);  
        isFade = false;
    }

    private IEnumerator FadeOutCoroutine()
    {
        float timeElapsed = 0f;
        Color initialColor = fadeImage.color;

        while (timeElapsed < fadeDuration)
        {
            fadeImage.color = Color.Lerp(initialColor, new Color(0, 0, 0, 0), timeElapsed / fadeDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }

        fadeImage.color = new Color(0, 0, 0, 0);  
        isFade = false;
    }
}
