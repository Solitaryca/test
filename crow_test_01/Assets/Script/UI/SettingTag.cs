using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SettingTag : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string keyname;
    private GameObject SettingKeyObj;

    void Start()
    {
        SettingKeyObj = transform.parent.parent.gameObject;
    }

    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (SettingKeyObj.GetComponent<SettingKey>().isusingMouse == true)
        {
            SettingKeyObj.GetComponent<SettingKey>().settingName = keyname;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (SettingKeyObj.GetComponent<SettingKey>().isusingMouse == true)
        {
            SettingKeyObj.GetComponent<SettingKey>().settingName = null;
        }
    }
}
