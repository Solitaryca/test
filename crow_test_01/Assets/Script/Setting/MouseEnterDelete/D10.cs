using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D10 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe10;

    private void Start()
    {
        isMouseDe10 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe10 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe10 = false;
    }
}