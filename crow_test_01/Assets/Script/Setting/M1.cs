using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class M1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseM1;

    private void Start()
    {
        isMouseM1 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseM1 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseM1 = false;
    }
}
