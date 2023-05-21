using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Slider slider;
    public int health;

    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
