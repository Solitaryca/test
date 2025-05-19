using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class T3 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseT3;

    private void Start()
    {
        isMouseT3 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseT3 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseT3 = false;
    }
}

