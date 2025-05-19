using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnterCon : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseCon;

    private void Start()
    {
        isMouseCon = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseCon = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseCon = false;
    }
}



