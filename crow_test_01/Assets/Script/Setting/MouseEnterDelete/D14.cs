using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D14 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe14;

    private void Start()
    {
        isMouseDe14 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe14 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe14 = false;
    }
}