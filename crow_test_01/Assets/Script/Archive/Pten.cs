using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pten : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseTen;

    private void Start()
    {
        isMouseTen = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseTen = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseTen = false;
    }
}
