using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NoCover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseNoCo;

    private void Start()
    {
        isMouseNoCo = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseNoCo = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseNoCo = false;
    }
}
