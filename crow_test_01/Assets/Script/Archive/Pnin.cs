using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pnin : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseNine;

    private void Start()
    {
        isMouseNine = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseNine = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseNine = false;
    }
}
