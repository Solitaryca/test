using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D16 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe16;

    private void Start()
    {
        isMouseDe16 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe16 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe16 = false;
    }
}