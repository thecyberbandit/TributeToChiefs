using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    
    public SlideshowController[] slideshowControllers = new SlideshowController[4];

    //[HideInInspector]
    public bool landingpageDisplay1;
    [HideInInspector]
    public bool landingpageDisplay2;
    [HideInInspector]
    public bool landingpageDisplay3;
    [HideInInspector]
    public bool landingpageDisplay4;

    //[HideInInspector]
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
        landingpageDisplay1 = true;
        landingpageDisplay2 = true;
        landingpageDisplay3 = true;
        landingpageDisplay4 = true;

        slideShowDisplay1 = false;
        slideShowDisplay2 = false;
        slideShowDisplay3 = false;
        slideShowDisplay4 = false;
    }

    private void Update()
    {
        //user has entered withing the range of the sensor
        if (Input.GetKey(KeyCode.W))
        {
            slideShowDisplay1 = true;
            landingpageDisplay1 = false;
            Debug.Log("W pressed");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            slideShowDisplay2 = true;
            landingpageDisplay2 = false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            slideShowDisplay3 = true;
            landingpageDisplay3 = false;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            slideShowDisplay4 = true;
            landingpageDisplay4 = false;
        }

        //user has left the range of the sensor
        //if (Input.GetKeyUp(KeyCode.W))
        //{
        //    slideShowDisplay1 = false;
        //    landingpageDisplay1 = true;
        //}
        //if (Input.GetKeyUp(KeyCode.DownArrow))
        //{
        //    slideShowDisplay2 = false;
        //    landingpageDisplay2 = true;
        //}
        //if (Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    slideShowDisplay3 = false;
        //    slideShowDisplay3 = true;
        //}
        //if (Input.GetKeyUp(KeyCode.LeftArrow))
        //{
        //    slideShowDisplay4 = false;
        //    landingpageDisplay4 = true;
        //}

        //start slideshow
        if (slideShowDisplay1)
        {
            slideshowControllers[0].SlideShow();
            slideShowDisplay1 = false;
        }
        //if (slideShowDisplay2)
        //{
        //    slideshowControllers[1].SlideShow();
        //    slideShowDisplay2 = false;
        //}
        //if (slideShowDisplay3)
        //{
        //    slideshowControllers[2].SlideShow();
        //    slideShowDisplay3 = false;
        //}
        //if (slideShowDisplay4)
        //{
        //    slideshowControllers[3].SlideShow();
        //    slideShowDisplay4 = false;
        //}

        //show landing page
        //if (landingpageDisplay1)
        //{
        //    slideshowControllers[0].ShowLandingPage();
        //}
        //if (landingpageDisplay2)
        //{
        //    slideshowControllers[1].ShowLandingPage();
        //}
        //if (landingpageDisplay3)
        //{
        //    slideshowControllers[2].ShowLandingPage();
        //}
        //if (landingpageDisplay4)
        //{
        //    slideshowControllers[3].ShowLandingPage();
        //}
    }
}
