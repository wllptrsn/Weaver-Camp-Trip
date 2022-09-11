using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DigitalClock : MonoBehaviour
{

    public int DelayAmount = 1; // Second count
    private Text textClock;
    public int hr = 3;
    public int min = 0;
    public string dayTime = "AM";
    protected float Timer;

    void Start(){
        textClock = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= DelayAmount)
         {
             Timer = 0f;
             min++; // For every DelayAmount or "second" it will add one to the GoldValue
             if(min == 60)
             {
                min =0;
                hr ++;
                if(hr == 13)
                {
                    hr = 1;
                    min = 0;
                }
                if(hr == 12){
                    if(dayTime == "AM"){
                        dayTime = "PM";
                    }
                    else if(dayTime == "PM"){
                        dayTime = "AM";
                    }
                }
                
             }

         }

        string hour = hr.ToString().PadLeft(2,'0');
        string minute = min.ToString().PadLeft(2,'0');
        textClock.text = hour + ":" + minute + " " + dayTime;
    }
}
