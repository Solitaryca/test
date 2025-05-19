using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Psit : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseSixteen;

    private void Start()
    {
        isMouseSixteen = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseSixteen = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseSixteen = false;
    }
}
