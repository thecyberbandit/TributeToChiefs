using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class SlideshowController : MonoBehaviour
{
    public RectTransform landingPage;
    public RectTransform[] rectTransforms;


    public void ShowLandingPage()
    {
        landingPage.DOAnchorPos(new Vector2(0, 0), 0f);
    }

    public void SlideShow()
    {
        landingPage.DOLocalMove(new Vector2(2700, 0), 0f);
        InvokeRepeating("Slides", 0f, 81.5f);
    }

    public void Slides()
    {
        float delay = 0f;

        for (int i = 0; i < rectTransforms.Length; i++)
        {
            MoveSlides(rectTransforms[i], new Vector2(0, 0), 0.5f, delay, Ease.OutFlash);
            delay += 5f;
        }
    }

    void MoveSlides(RectTransform _transform, Vector2 position, float moveTime, float delayTime, Ease ease)
    {
        Tween tween = _transform.DOAnchorPos(position, moveTime).SetDelay(delayTime).SetEase(ease);
        tween.OnComplete(() =>
        {
            Tween tweenBack = _transform.DOAnchorPos(new Vector2(2700, 0), 0f).SetDelay(5f).SetEase(ease);
        });
    }
}
