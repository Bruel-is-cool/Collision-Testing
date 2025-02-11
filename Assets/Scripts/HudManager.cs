using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{
    public Slider healthSlider;

    // Update is called once per frame
    public void UpdateHealthBar(float value)
    {
        healthSlider.value = value;
    }
}
