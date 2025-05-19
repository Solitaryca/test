using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pfot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseForteen;

    private void Start()
    {
        isMouseForteen = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseForteen = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseForteen = false;
    }
}
