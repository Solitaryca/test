using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class T2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseT2;

    private void Start()
    {
        isMouseT2 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseT2 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseT2 = false;
    }
}
