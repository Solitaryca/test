using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe1;

    private void Start()
    {
        isMouseDe1 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe1 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe1 = false;
    }
}
