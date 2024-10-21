using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private Image messageImage;

    public void PlayGame()
    {
        messageImage.enabled = false;
        GameManager.Instance.StartGame();
    }
}
