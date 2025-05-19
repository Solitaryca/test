using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SettingItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string currentname;
    private GameObject SettingKeyObj;
    private GameObject backgroundObj;

    private void Start()
    {
        backgroundObj = transform.GetChild(0).gameObject;
        SettingKeyObj = transform.parent.parent.gameObject;
    }

    public void ShowBackground()
    {
        backgroundObj.SetActive(true);
    }

    public void HideBackground() 
    { 
        backgroundObj.SetActive(false); 
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (SettingKeyObj.GetComponent<SettingKey>().isusingMouse == true)
        {
            //SettingKeyObj.GetComponent<SettingKey>().ShowUIBackground(currentname);
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {

        if (SettingKeyObj.GetComponent<SettingKey>().isusingMouse == true)
        {
            //SettingKeyObj.GetComponent<SettingKey>().HideUIBackground(currentname);
        }
    }
}
