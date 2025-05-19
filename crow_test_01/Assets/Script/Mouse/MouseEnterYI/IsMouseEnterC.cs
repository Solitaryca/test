using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IsMouseEnterC : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseC;

    private void Start()
    {
        isMouseC = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseC = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseC = false;
    }
}
