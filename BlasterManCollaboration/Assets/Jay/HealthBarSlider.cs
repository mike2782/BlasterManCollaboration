using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : MonoBehaviour
{
    public Slider slider;
    [SerializeField]
    public PlayerDamageController player;
    void Update()

    {
        //slider.maxValue = player.egoMeter;
        slider.value = player.egoMeter;
        //slider.value = health;
    }
        
    }

