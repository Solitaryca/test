using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Peig : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseEight;

    private void Start()
    {
        isMouseEight = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseEight = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseEight = false;
    }
}
