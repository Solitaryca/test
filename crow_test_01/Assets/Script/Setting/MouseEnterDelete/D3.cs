using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D3 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe3;

    private void Start()
    {
        isMouseDe3 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe3 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe3 = false;
    }
}