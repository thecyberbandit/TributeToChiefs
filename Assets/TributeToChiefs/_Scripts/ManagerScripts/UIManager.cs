using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public Image[] backgroundImages;
    public SlideshowController slideshowController;

    [HideInInspector]
    public bool slideShowDisplay1;
    [HideInInspector]
    public bool slideShowDisplay2;
    [HideInInspector]
    public bool slideShowDisplay3;
    [HideInInspector]
    public bool slideShowDisplay4;


    private void Awake()
    {
        if (instance != null)
            Destroy(this.gameObject);

        instance = this;
    }

    private void Start()
    {
        slideShowDisplay1 = false;
        slideShowDisplay2 = false;
        slideShowDisplay3 = false;
        slideShowDisplay4 = false;
    }

    private void Update()
    {
        //user has entered withing the range of the sensor
        if (Input.GetKey(KeyCode.UpArrow))
            slideShowDisplay1 = true;
        if (Input.GetKey(KeyCode.DownArrow))
            slideShowDisplay2 = true;
        if (Input.GetKey(KeyCode.LeftArrow))
            slideShowDisplay3 = true;
        if (Input.GetKey(KeyCode.RightArrow))
            slideShowDisplay4 = true;

        //user has left the range of the sensor
        if (Input.GetKeyUp(KeyCode.UpArrow))
            slideShowDisplay1 = false;
        if (Input.GetKeyUp(KeyCode.DownArrow))
            slideShowDisplay2 = false;
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            slideShowDisplay3 = false;
        if (Input.GetKeyUp(KeyCode.RightArrow))
            slideShowDisplay4 = false;

        //start slideshow or show landing page
        if (slideShowDisplay1)
            slideshowController.SlideShow();
        else
            //slideshowController.ShowLandingPage(backgroundImages[0]);

        if (slideShowDisplay2)
            slideshowController.SlideShow();
        else
            slideshowController.ShowLandingPage(backgroundImages[1]);

        if (slideShowDisplay3)
            slideshowController.SlideShow();
        else
            slideshowController.ShowLandingPage(backgroundImages[2]);

        if (slideShowDisplay4)
            slideshowController.SlideShow();
        else
            slideshowController.ShowLandingPage(backgroundImages[3]);
    }

    //public void OnBottomImageClicked(Button button)
    //{
    //    backgroundImage.sprite = button.GetComponent<Image>().sprite;
    //}
}
