using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GravGyroAcc : MonoBehaviour
{
    public Text txt;

    private void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Input.acceleration="+Input.acceleration.ToString("F3") + " \n Input.gyro.gravity=" + Input.gyro.gravity.ToString("F3") + " Screen.orientation="+ Screen.orientation +" \n Input.gyro.attitude=" +Input.gyro.attitude.ToString("F3");
    }
}
