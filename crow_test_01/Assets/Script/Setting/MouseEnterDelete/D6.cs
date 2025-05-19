using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D6 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe6;

    private void Start()
    {
        isMouseDe6 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe6 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe6 = false;
    }
}