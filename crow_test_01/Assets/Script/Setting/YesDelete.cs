using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class YesDelete : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseYesDe;

    private void Start()
    {
        isMouseYesDe = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseYesDe = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseYesDe = false;
    }
}
