using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDetector : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private BottomPanelHandler bottomPanel;


    private void Start()
    {
        //bottomPanel = GetComponentInParent<BottomPanelHandler>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //bottomPanel.PauseSlideShow();
    }

    public void OnDrag(PointerEventData eventData)
    {
        //bottomPanel.PauseSlideShow();
    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }
}
