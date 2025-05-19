using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pthr : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseThree;

    private void Start()
    {
        isMouseThree = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseThree = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseThree = false;
    }
}
