using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popupmanager : MonoBehaviour
{
    public GameObject PopupUI;

    void Start()
    {
        Time.timeScale = 0;
    }

    public void CloseMenu()
    {
        PopupUI.SetActive(false);
        Time.timeScale = 1f;
    }


}
