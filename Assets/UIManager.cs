using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image backgroundImage;

    public void OnBottomImageClicked(Button button)
    {
        backgroundImage.sprite = button.GetComponent<Image>().sprite;
    }
}
