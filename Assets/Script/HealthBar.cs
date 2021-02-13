using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider _slider;
    
    void SetMaxHealth(int health)
    {
        _slider.maxValue = health;
        _slider.value = health;
    }

    
    void SetHealth(int health)
    {
        _slider.value = health;
    }
}
