using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ptht : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseThirteen;

    private void Start()
    {
        isMouseThirteen = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseThirteen = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseThirteen = false;
    }
}
