using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Slider slider;
    public void doSome()
    {
        Debug.Log(slider.value.ToString());
    }
}
