using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IsMouseEnterA : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseA;

    private void Start()
    {
        isMouseA = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseA = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseA = false;
    }
}
