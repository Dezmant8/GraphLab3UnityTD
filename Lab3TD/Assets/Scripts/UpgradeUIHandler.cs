using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UpgradeUIHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool mouseOver = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouseOver = true;
        UIManagerScript.main.SetHoveringState(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouseOver = false;
        UIManagerScript.main.SetHoveringState(false);
        gameObject.SetActive(false);
    }
}
