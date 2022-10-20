using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DigitalClock : MonoBehaviour
{

    public int DelayAmount = 1; // Second count
    private Text textClock;
    private Text textDay;
    public int hr = 3;
    public int min = 0;
    public string dayTime = "AM";
    protected float Timer;

    public GameObject uiFind;
    public GameObject settingsTime;
    public Text settingsTimeTxt;
    string[] days = {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
    int day = 0;

    public GameObject today;
    public GameObject yesterday;
    public GameObject lastDay;

    public Image todayImg;
    public Image yesterdayImg;
    public Image lastDayImg;
    public Sprite whiteBlock;
    public Sprite yellowBlock;


    public GameObject dark;

    void Start(){
        textClock = GetComponent<Text>();
        uiFind= GameObject.Find("UI Canvas");
        settingsTime = uiFind.transform.GetChild(1).GetChild(1).GetChild(1).GetChild(2).gameObject;
        settingsTimeTxt = settingsTime.GetComponent<Text>();

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
                        day++;
                        dayTime = "AM";
                    }
                }
                if(day ==7 && hr == 3 && dayTime == "PM")
                {
                    day = 0;
                }

                if(day > 0)
                {
            yesterday = uiFind.transform.GetChild(1).GetChild(1).GetChild(1).GetChild(1).GetChild(day-1).gameObject;
            yesterdayImg = yesterday.GetComponent<Image>();
            yesterdayImg.sprite = whiteBlock;
            print(yesterday);
                }if(day == 0)
                {
            lastDay = uiFind.transform.GetChild(1).GetChild(1).GetChild(1).GetChild(1).GetChild(7).gameObject;
            lastDayImg = lastDay.GetComponent<Image>();
            lastDayImg.sprite = whiteBlock;
                }
             }

         }

        string hour = hr.ToString().PadLeft(2,'0');
        string minute = min.ToString().PadLeft(2,'0');
        today = uiFind.transform.GetChild(1).GetChild(1).GetChild(1).GetChild(1).GetChild(day).gameObject;
        todayImg = today.GetComponent<Image>();
        todayImg.sprite = yellowBlock;
        textClock.text = hour + ":" + minute + " " + dayTime;
        settingsTimeTxt.text = days[day] + " " + textClock.text;
        todayImg.sprite = yellowBlock;


        if((hr>=9 && dayTime == "PM") || (hr<=4 && dayTime == "AM"))
        {
            dark.SetActive(true);
            print(hr);
        }
        else if(hr == 12 && dayTime == "AM")
        {
            dark.SetActive(true);
        }
        else
        {
            dark.SetActive(false);
        }
        
    }
}
