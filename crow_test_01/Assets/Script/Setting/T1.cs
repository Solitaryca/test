using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class T1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseT1;

    private void Start()
    {
        isMouseT1 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseT1 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseT1 = false;
    }
}
