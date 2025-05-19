using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneExit : MonoBehaviour
{
    [Tooltip("ÐÂ³¡¾°Ãû³Æ")]
    public string newSceneName;

    [SerializeField] private string newScenePw;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            crow_sport.instance.scenePw = newScenePw;
            FindAnyObjectByType<SceneFader>().FadeTo(newSceneName);
        }
    }
}
