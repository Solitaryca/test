using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pfit : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseFifteen;

    private void Start()
    {
        isMouseFifteen = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseFifteen = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseFifteen = false;
    }
}
