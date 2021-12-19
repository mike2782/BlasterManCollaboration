using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBarSlider : MonoBehaviour
{ 
    public Slider slider;
    [SerializeField]
    public playerController player;
    void Update()

{
         //slider.maxValue = player.egoMeter;
         slider.value = player.energyMeter;
         //slider.value = health;
}
        
    }
