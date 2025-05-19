using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IsMouseEnterB : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseB;

    private void Start()
    {
        isMouseB = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseB = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseB = false;
    }
}
