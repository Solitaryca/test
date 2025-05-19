using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ptwo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseTwo;

    private void Start()
    {
        isMouseTwo = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseTwo = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseTwo = false;
    }
}
