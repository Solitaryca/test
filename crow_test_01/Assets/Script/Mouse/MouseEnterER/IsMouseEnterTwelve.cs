using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IsMouseEnterTwelve : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseTwelve;

    private void Start()
    {
        isMouseTwelve = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseTwelve = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseTwelve = false;
    }
}
