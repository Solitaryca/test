using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class YesCover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseYesCo;

    private void Start()
    {
        isMouseYesCo = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseYesCo = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseYesCo = false;
    }
}
