using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Psev : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseSeven;

    private void Start()
    {
        isMouseSeven = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseSeven = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseSeven = false;
    }
}
