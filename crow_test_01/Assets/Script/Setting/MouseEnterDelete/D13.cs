using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D13 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe13;

    private void Start()
    {
        isMouseDe13 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe13 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe13 = false;
    }
}