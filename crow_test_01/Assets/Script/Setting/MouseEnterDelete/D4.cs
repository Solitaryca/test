using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D4 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe4;

    private void Start()
    {
        isMouseDe4 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe4 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe4 = false;
    }
}