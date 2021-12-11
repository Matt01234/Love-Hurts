using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image slider;
    // SetMaxHealth function sets the max health
    // @param health sets the slider fill amount
    public void SetMaxHealth(float health)
    {
        slider.fillAmount = health;
    }
    // SetHealth function sets the health
    // @param health sets the slider fill amount
    public void SetHealth(float health)
    {
        slider.fillAmount = health;    
    }
}
