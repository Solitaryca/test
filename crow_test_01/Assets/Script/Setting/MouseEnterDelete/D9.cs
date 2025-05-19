using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D9 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe9;

    private void Start()
    {
        isMouseDe9 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe9 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe9 = false;
    }
}