using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Sources
// https://www.youtube.com/watch?v=BLfNP4Sc_iA

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public float health;

    // Begin the MaxHealth with 100.
    void Start()
    {
        SetMaxHealth(100);
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

    }
    
    public void SetHealth(int health)
    {
        slider.value = health;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health = health - 10f;
            SetHealth(10); // set the health bar with changed health.
        }
    }
}
