using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnterExit : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseExit;

    private void Start()
    {
        isMouseExit = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseExit = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseExit = false;
    }
}


