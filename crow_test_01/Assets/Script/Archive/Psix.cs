using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Psix : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseSix;

    private void Start()
    {
        isMouseSix = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseSix = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseSix = false;
    }
}
