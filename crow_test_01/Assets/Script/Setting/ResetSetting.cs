using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetSetting : MonoBehaviour
{
    private void Update()
    {
        if (FindAnyObjectByType<SettingKey>().reset.activeInHierarchy)
        {
            if (Input.GetKeyDown(GameManager.GM.sure) || Input.GetMouseButtonDown(0))
            {
                ResetKeysToDefaults();
            }
        }
    }

    private void ResetKeysToDefaults()
    {
        GameManager.GM.sure = KeyCode.C;
        GameManager.GM.run = KeyCode.LeftShift;
        GameManager.GM.get = KeyCode.V;
        GameManager.GM.dash = KeyCode.Space;
        GameManager.GM.back = KeyCode.Tab;
        GameManager.GM.attack = KeyCode.X;
        GameManager.GM.wind = KeyCode.N;
        GameManager.GM.sound = KeyCode.M;
        GameManager.GM.map = KeyCode.LeftAlt;
        GameManager.GM.shine = KeyCode.Q;

        PlayerPrefs.SetString("sureKey", GameManager.GM.sure.ToString());
        PlayerPrefs.SetString("runKey", GameManager.GM.run.ToString());
        PlayerPrefs.SetString("getKey", GameManager.GM.get.ToString());
        PlayerPrefs.SetString("dashKey", GameManager.GM.dash.ToString());
        PlayerPrefs.SetString("backKey", GameManager.GM.back.ToString());
        PlayerPrefs.SetString("attackKey", GameManager.GM.attack.ToString());
        PlayerPrefs.SetString("windKey", GameManager.GM.wind.ToString());
        PlayerPrefs.SetString("soundKey", GameManager.GM.sound.ToString());
        PlayerPrefs.SetString("mapKey", GameManager.GM.map.ToString());
        PlayerPrefs.SetString("shineKey", GameManager.GM.shine.ToString());

        UpdateUIWithDefaultKeys();
    }

    private void UpdateUIWithDefaultKeys()
    {
        KeyChangeSetting keyChangeSetting = FindAnyObjectByType<KeyChangeSetting>();
        if (keyChangeSetting != null)
        {
            keyChangeSetting.RefreshKeyBindings(); 
        }
    }
}
