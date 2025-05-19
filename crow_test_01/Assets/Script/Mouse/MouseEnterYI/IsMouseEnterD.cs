using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IsMouseEnterD : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseD;

    private void Start()
    {
        isMouseD = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseD = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseD = false;
    }
}
