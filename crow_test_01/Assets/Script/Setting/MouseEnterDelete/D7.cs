using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D7 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe7;

    private void Start()
    {
        isMouseDe7 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe7 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe7 = false;
    }
}