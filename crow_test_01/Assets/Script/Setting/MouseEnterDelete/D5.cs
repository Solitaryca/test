using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D5 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe5;

    private void Start()
    {
        isMouseDe5 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe5 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe5 = false;
    }
}