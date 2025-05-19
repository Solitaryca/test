using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D8 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe8;

    private void Start()
    {
        isMouseDe8 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe8 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe8 = false;
    }
}