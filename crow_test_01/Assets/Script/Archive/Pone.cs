using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pone : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseOne;

    private void Start()
    {
        isMouseOne = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseOne = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseOne = false;
    }
}
