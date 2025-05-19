using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class D2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isMouseDe2;

    private void Start()
    {
        isMouseDe2 = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseDe2 = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseDe2 = false;
    }
}