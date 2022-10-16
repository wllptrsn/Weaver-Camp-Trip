using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class PlayerScore : MonoBehaviour
{
    private Text textScore;
    public int scr = 0;
    protected float Timer;
    // Start is called before the first frame update
    void Start()
    {
    textScore = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        string score = scr.ToString().PadLeft(3,'0');
        textScore.text = score;
        
    }
}
