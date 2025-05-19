using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnterChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseChange;

    private void Start()
    {
        isMouseChange = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseChange = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseChange = false;
    }
}

