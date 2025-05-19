using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour
{
    public TMP_Text testText;

    IEnumerator TypeText(TMP_Text tMP_Text, string str, float interval)
    {
        int i = 0;
        while (i <= str.Length)
        {
            tMP_Text.text = str.Substring(0, i);
            i++;
            yield return new WaitForSeconds(interval);
        }
    }

    private void Start()
    {
        // 确保testText已经在Inspector中设置
        if (testText != null)
        {
            StartCoroutine(TypeText(testText, testText.text, 0.1f));
        }
    }
}

