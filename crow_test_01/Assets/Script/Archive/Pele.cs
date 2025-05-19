using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pele : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseEleven;

    private void Start()
    {
        isMouseEleven = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseEleven = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseEleven = false;
    }
}
