using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;

    public KeyCode sure { get; set; }
    public KeyCode run { get; set; }
    public KeyCode get { get; set; }
    public KeyCode dash { get; set; }
    public KeyCode back { get; set; }
    public KeyCode attack { get; set; }
    public KeyCode wind { get; set; }
    public KeyCode sound { get; set; }
    public KeyCode map { get; set; }
    public KeyCode shine { get; set; }

    void Awake()
    {
        if(GM == null)
        {
            DontDestroyOnLoad(gameObject);
            GM = this;
        }
        else if(GM != this)
        {
            Destroy(gameObject);
        }
        sure = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("sureKey", "C"));
        run = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("runKey", "LeftShift"));
        get = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("getKey", "V"));
        dash = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("dashKey", "Space"));
        back = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("backKey", "Tab"));
        attack = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("attackKey", "X"));
        wind = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("windKey", "N"));
        sound = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("soundKey", "M"));
        map = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("mapKey", "LeftAlt"));
        shine = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("shineKey", "Q"));
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
