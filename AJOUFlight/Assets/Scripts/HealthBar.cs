using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Link to the tutor video
// https://www.youtube.com/watch?v=BLfNP4Sc_iA

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        // If we want to healthbar to change color from the green to red
        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = health;

        // If we want to healthbar to change color from the green to red
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
