using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D15 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe15;

    private void Start()
    {
        isMouseDe15 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe15 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe15 = false;
    }
}