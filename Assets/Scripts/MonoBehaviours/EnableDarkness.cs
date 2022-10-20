using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDarkness : MonoBehaviour
{
    public GameObject uiFind;
    public GameObject clockDisplay;
    public DigitalClock digitalClock;
    public GameObject dark;
    // Start is called before the first frame update
    void Start()
    {
        uiFind= GameObject.Find("UI Canvas");
        clockDisplay = uiFind.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(0).gameObject;
        digitalClock = clockDisplay.GetComponent<DigitalClock>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if((digitalClock.hr>=9 && digitalClock.dayTime == "PM") || (digitalClock.hr<=5 && digitalClock.dayTime == "AM"))
        {
            dark.SetActive(true);
            print(digitalClock.hr);
        }
        else
        {
            dark.SetActive(false);
        }
        
    }
}
