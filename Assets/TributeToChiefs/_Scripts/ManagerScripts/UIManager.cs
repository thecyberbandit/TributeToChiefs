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
        if (Input.GetKey(KeyCode.W) && !slideShowDisplay1)
        {
            Debug.Log("W pressed");
            slideshowControllers[0].canDisplay = true;
            slideshowControllers[0].SlideShow();
            slideShowDisplay1 = true;
        }
        if (Input.GetKey(KeyCode.A) && !slideShowDisplay2)
        {
            Debug.Log("A pressed");
            slideshowControllers[1].canDisplay = true;
            slideshowControllers[1].SlideShow();
            slideShowDisplay2 = true;
        }
        if (Input.GetKey(KeyCode.S) && !slideShowDisplay3)
        {
            Debug.Log("S pressed");
            slideshowControllers[2].canDisplay = true;
            slideshowControllers[2].SlideShow();
            slideShowDisplay3 = true;
        }
        if (Input.GetKey(KeyCode.D) && !slideShowDisplay4)
        {
            Debug.Log("D pressed");
            slideshowControllers[3].canDisplay = true;
            slideshowControllers[3].SlideShow();
            slideShowDisplay4 = true;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("W gone");
            slideshowControllers[0].canDisplay = false;
            slideShowDisplay1 = false;
            slideshowControllers[0].ShowLandingPage();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("A gone");
            slideshowControllers[1].canDisplay = false;
            slideShowDisplay2 = false;
            slideshowControllers[1].ShowLandingPage();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            Debug.Log("S gone");
            slideshowControllers[2].canDisplay = false;
            slideShowDisplay3 = false;
            slideshowControllers[2].ShowLandingPage();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("D gone");
            slideshowControllers[3].canDisplay = false;
            slideShowDisplay4 = false;
            slideshowControllers[3].ShowLandingPage();
        }
    }
}
