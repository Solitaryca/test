using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D11 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe11;

    private void Start()
    {
        isMouseDe11 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe11 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe11 = false;
    }
}