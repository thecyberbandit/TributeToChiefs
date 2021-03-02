using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.Rendering;

public class SlideshowController : MonoBehaviour
{
    [Header("SlideShow")]
    public Sprite landingPage;
    public Sprite[] chiefSprites;
    public float slideshowDelay;
    public AnimationClip fadeClip;

    [Header("Video Player")]
    public VideoClip[] chiefClips;
    public VideoClip landingClip;
    public VideoPlayer videoPlayer;
    public RenderTexture renderTexture;

    [Header("Tweening")]
    public RectTransform slide;

    [Header("Bottom Panel")]
    public GameObject scrollbar;
    public GameObject nextButton;
    public GameObject prevButton;

    [HideInInspector]
    public Tween tween;
    [HideInInspector]
    public Tween tweenback;

    private int currentID;
    private Sprite slideSprite;
    private Animator slideAnim;
    private Image slideImage;


    private void Start()
    {
        //slideSprite = slide.GetComponent<SpriteRenderer>().sprite;
        renderTexture.Release();
        slideAnim = slide.GetComponent<Animator>();
        slideImage = slide.GetComponent<Image>();
    }

    public void ShowLandingPage()
    {
        //scrollbar.SetActive(false);
        //nextButton.SetActive(false);
        //prevButton.SetActive(false);
        slideImage.canvasRenderer.SetAlpha(1f);
        slideAnim.SetTrigger("idle");
        slideImage.sprite = landingPage;

        Tween landingTween = slide.DOAnchorPos(new Vector2(0, 0), 0f).SetDelay(0f).SetEase(Ease.OutFlash);

        landingTween.OnComplete(() =>
        {
            slideAnim.SetTrigger("fade");
            videoPlayer.clip = landingClip;
            videoPlayer.Play();
            tweenback = slide.DOAnchorPos(new Vector2(2700, 0), 0f).SetDelay(1f).SetEase(Ease.OutFlash);
        });
    }

    public void SlideShow()
    {
        //landingPage.DOAnchorPos(new Vector2(-2700, 0), 0f).SetDelay(1f);
        //rectTransforms[currentID].DOAnchorPos(new Vector2(2700, 0), 0f);
        //scrollbar.SetActive(true);
        //nextButton.SetActive(true);
        //prevButton.SetActive(true);
        //InvokeRepeating("Slides", 0f, 81.5f);
        InvokeRepeating("SlideChanger", 0f, slideshowDelay);
    }

    public void SlideChanger()
    {
        StartCoroutine(ChangeSprites());
    }

    IEnumerator ChangeSprites()
    {
        for (int i = 0; i < chiefSprites.Length; i++)
        {
            //renderTexture.Release();
            slideAnim.SetTrigger("idle");
            slideImage.sprite = chiefSprites[i];

            MoveSlides(i, new Vector2(0, 0), 1f, Ease.OutFlash);
            yield return new WaitForSeconds(5f);
        }
    }

    public void Slides()
    {
        float delay = 0f;

        for (int i = 0; i < chiefSprites.Length; i++)
        {
            currentID = i;
            //MoveSlides(currentID, new Vector2(0, 0), 1f, delay, Ease.OutFlash);
            delay += 10f;
        }
    }

    //public void ShowSlide(int ID)
    //{
    //    rectTransforms[currentID].DOAnchorPos(new Vector2(2700, 0), 0f).SetDelay(0f);
    //    rectTransforms[ID].DOAnchorPos(new Vector2(0, 0), 0.5f).SetDelay(0f);
    //    currentID = ID;
    //    //Debug.Log(ID);
    //}

    void MoveSlides(int id, Vector2 position, float moveTime, Ease ease)
    {
        tween = slide.DOAnchorPos(position, moveTime).SetDelay(0f).SetEase(ease);

        tween.OnComplete(() =>
        {
            //slideImage.CrossFadeAlpha(0, 0.5f, false);
            slideAnim.SetTrigger("fade");
            //yield return new WaitForSeconds(fadeClip.length);
            videoPlayer.clip = chiefClips[id];
            videoPlayer.Play();
            tweenback = slide.DOAnchorPos(new Vector2(2700, 0), 0f).SetDelay(2f).SetEase(ease);
            //videoPlayer.Stop();
            //renderTexture.Release();
        });
    }
}
