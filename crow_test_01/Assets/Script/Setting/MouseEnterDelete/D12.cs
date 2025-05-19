using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D12 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe12;

    private void Start()
    {
        isMouseDe12 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe12 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe12 = false;
    }
}