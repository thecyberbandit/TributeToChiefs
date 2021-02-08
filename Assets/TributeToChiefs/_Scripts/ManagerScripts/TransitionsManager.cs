using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TransitionsManager : MonoBehaviour
{
    public void RightToCenter(RectTransform rect)
    {
        rect.DOLocalMove(Vector2.zero, 0.5f);
    }

    public void LeftToRight(RectTransform rect)
    {
        rect.DOLocalMove(new Vector2(1150f, 0f), 0f);
    }

    public void RightToLeft(RectTransform rect)
    {
        rect.DOLocalMove(new Vector2(-1150f, 0f), 0.5f);
    }
}
