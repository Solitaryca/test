using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NoDelete : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseNoDe;

    private void Start()
    {
        isMouseNoDe = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseNoDe = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseNoDe = false;
    }
}
