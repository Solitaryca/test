using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pfiv : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseFive;

    private void Start()
    {
        isMouseFive = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseFive = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseFive = false;
    }
}
