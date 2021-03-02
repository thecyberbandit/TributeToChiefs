using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class BottomPanelHandler : MonoBehaviour
{
    public ListPositionCtrl listPosition;
    public float waitTime;

    private SlideshowController slideshow;
    private bool isInteracting;

    private void Start()
    {
        slideshow = this.GetComponent<SlideshowController>();

        waitTime = 0.5f;
    }

    public void PauseSlideShow()
    {
        DOTween.PauseAll();
        isInteracting = true;
        waitTime = 0.5f;
        InvokeRepeating("CheckTimer", 0f, 0.1f);
    }

    public void RestartSlideShow()
    {
        DOTween.PlayAll();
    }

    //void CheckTimer()
    //{
    //    int currentCenterID = listPosition.GetCenteredContentID();
    //    ListBox box = listPosition.GetCenteredBox();

    //    box.ShowBoxInfo();

    //    if (isInteracting)
    //    {
    //        waitTime -= Time.deltaTime;
    //        slideshow.ShowSlide(currentCenterID);
    //    }

    //    if (waitTime <= 0)
    //    {
    //        RestartSlideShow();
    //        isInteracting = false;
    //    }
    //}
}
