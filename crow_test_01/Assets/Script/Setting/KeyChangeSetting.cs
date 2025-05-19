using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeyChangeSetting : MonoBehaviour
{
    Transform settingPanel;
    Event KeyEvent;
    TextMeshProUGUI buttonText;
    KeyCode newKey;
    bool waitingForKey;
    public bool isFinish;

    void Start()
    {
        settingPanel = transform.Find("resetting");
        waitingForKey = false;
        isFinish = true;

        for(int i = 0; i < 10; i++)
        {
            if(settingPanel.GetChild(i).name == "sure")
            {
                settingPanel.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text = GameManager.GM.sure.ToString();
            }
            else if (settingPanel.GetChild(i).name == "run")
            {
                settingPanel.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text = GameManager.GM.run.ToString();
            }
            else if (settingPanel.GetChild(i).name == "get")
            {
                settingPanel.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text = GameManager.GM.get.ToString();
            }
            else if (settingPanel.GetChild(i).name == "dash")
            {
                settingPanel.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text = GameManager.GM.dash.ToString();
            }
            else if (settingPanel.GetChild(i).name == "back")
            {
                settingPanel.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text = GameManager.GM.back.ToString();
            }
            else if (settingPanel.GetChild(i).name == "attack")
            {
                settingPanel.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text = GameManager.GM.attack.ToString();
            }
            else if (settingPanel.GetChild(i).name == "wind")
            {
                settingPanel.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text = GameManager.GM.wind.ToString();
            }
            else if (settingPanel.GetChild(i).name == "sound")
            {
                settingPanel.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text = GameManager.GM.sound.ToString();
            }
            else if (settingPanel.GetChild(i).name == "map")
            {
                settingPanel.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text = GameManager.GM.map.ToString();
            }
            else if (settingPanel.GetChild(i).name == "shine")
            {
                settingPanel.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text = GameManager.GM.shine.ToString();
            }
        }
    }

    void Update()
    {
        
    }

    private void OnGUI()
    {
        KeyEvent = Event.current;

        if (KeyEvent.isKey && waitingForKey )
        {
            newKey = KeyEvent.keyCode;
            waitingForKey = false;
        }
    }

    public void StartAssignment(string KeyName)
    {
        if (!waitingForKey)
        {
            buttonText.text = "输入";
            isFinish = false;
            StartCoroutine(AssignKey(KeyName));
        }
    }

    public  void SendText(TextMeshProUGUI text)
    {
       buttonText = text;
    }

    IEnumerator WaitForKey()
    {
        while (!KeyEvent.isKey)
        {
            yield return null;
        }
    }

    private bool IsKeyAlreadyAssigned(KeyCode key, string currentKeyName)
    {
        var assignedKeys = new Dictionary<string, KeyCode>
        {
            {"sure", GameManager.GM.sure},
            {"run", GameManager.GM.run},
            {"get", GameManager.GM.get},
            {"dash", GameManager.GM.dash},
            {"back", GameManager.GM.back},
            {"attack", GameManager.GM.attack},
            {"wind", GameManager.GM.wind},
            {"sound", GameManager.GM.sound},
            {"map", GameManager.GM.map},
            {"shine", GameManager.GM.shine}
        };

        foreach (var entry in assignedKeys)
        {
            if (entry.Key != currentKeyName && entry.Value == key)
            {
                return true; 
            }
        }

        return false; 
    }


    public IEnumerator AssignKey(string KeyName)
    {
        waitingForKey = true;

        yield return WaitForKey();

        if (IsKeyAlreadyAssigned(newKey, KeyName))
        {
            buttonText.text = "重复按键";
            waitingForKey = false; 
            isFinish = false;
            yield break; 
        }

        switch (KeyName)
        {
            case "sure":
                GameManager.GM.sure = newKey;
                buttonText.text = GameManager.GM.sure.ToString();
                PlayerPrefs.SetString("sureKey", GameManager.GM.sure.ToString());
                break;

            case "run":
                GameManager.GM.run = newKey;
                buttonText.text = GameManager.GM.run.ToString();
                PlayerPrefs.SetString("runKey", GameManager.GM.run.ToString());
                break;

            case "get":
                GameManager.GM.get = newKey;
                buttonText.text = GameManager.GM.get.ToString();
                PlayerPrefs.SetString("getKey", GameManager.GM.get.ToString());
                break;

            case "dash":
                GameManager.GM.dash = newKey;
                buttonText.text = GameManager.GM.dash.ToString();
                PlayerPrefs.SetString("dashKey", GameManager.GM.dash.ToString());
                break;

            case "back":
                GameManager.GM.back = newKey;
                buttonText.text = GameManager.GM.back.ToString();
                PlayerPrefs.SetString("backKey", GameManager.GM.back.ToString());
                break;

            case "attack":
                GameManager.GM.attack = newKey;
                buttonText.text = GameManager.GM.attack.ToString();
                PlayerPrefs.SetString("attackKey", GameManager.GM.attack.ToString());
                break;

            case "wind":
                GameManager.GM.wind = newKey;
                buttonText.text = GameManager.GM.wind.ToString();
                PlayerPrefs.SetString("windKey", GameManager.GM.wind.ToString());
                break;

            case "sound":
                GameManager.GM.sound = newKey;
                buttonText.text = GameManager.GM.sound.ToString();
                PlayerPrefs.SetString("soundKey", GameManager.GM.sound.ToString());
                break;

            case "map":
                GameManager.GM.map = newKey;
                buttonText.text = GameManager.GM.map.ToString();
                PlayerPrefs.SetString("mapKey", GameManager.GM.map.ToString());
                break;

            case "shine":
                GameManager.GM.shine = newKey;
                buttonText.text = GameManager.GM.shine.ToString();
                PlayerPrefs.SetString("shineKey", GameManager.GM.shine.ToString());
                break;


        }

        bool hasDuplicateKey = false;
        for (int i = 0; i < 10; i++)
        {
            if (settingPanel.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text == "重复按键" || settingPanel.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text == "输入")
            {
                hasDuplicateKey = true;
                break; 
            }
        }
        isFinish = !hasDuplicateKey;

        waitingForKey = false;
        yield return null;
    }

    public void RefreshKeyBindings()
    {
        for (int i = 0; i < settingPanel.childCount; i++)
        {
            var button = settingPanel.GetChild(i);
            var buttonText = button.GetComponentInChildren<TextMeshProUGUI>();

            switch (button.name)
            {
                case "sure":
                    buttonText.text = GameManager.GM.sure.ToString();
                    break;
                case "run":
                    buttonText.text = GameManager.GM.run.ToString();
                    break;
                case "get":
                    buttonText.text = GameManager.GM.get.ToString();
                    break;
                case "dash":
                    buttonText.text = GameManager.GM.dash.ToString();
                    break;
                case "back":
                    buttonText.text = GameManager.GM.back.ToString();
                    break;
                case "attack":
                    buttonText.text = GameManager.GM.attack.ToString();
                    break;
                case "wind":
                    buttonText.text = GameManager.GM.wind.ToString();
                    break;
                case "sound":
                    buttonText.text = GameManager.GM.sound.ToString();
                    break;
                case "map":
                    buttonText.text = GameManager.GM.map.ToString();
                    break;
                case "shine":
                    buttonText.text = GameManager.GM.shine.ToString();
                    break;
            }
        }
    }
}
