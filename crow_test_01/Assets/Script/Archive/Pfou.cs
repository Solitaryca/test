using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pfou : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseFour;

    private void Start()
    {
        isMouseFour = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseFour = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseFour = false;
    }
}
