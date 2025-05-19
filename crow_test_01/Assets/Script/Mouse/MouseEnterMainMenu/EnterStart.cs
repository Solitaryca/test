using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnterStart : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseStart;

    private void Start()
    {
        isMouseStart = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseStart = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseStart = false;
    }
}


