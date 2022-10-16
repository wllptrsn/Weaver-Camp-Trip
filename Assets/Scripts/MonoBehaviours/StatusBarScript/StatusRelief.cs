using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusRelief : MonoBehaviour
{

   public GameObject uiFind;
   public GameObject relief;
   public UIFill uiFill;
   protected float Timer;
   public int DelayAmount =1;
   public double plus;
   public int relieveState;
   
   void Awake()
   {
    uiFind= GameObject.Find("UI Canvas");
    relief = uiFind.transform.GetChild(0).GetChild(0).GetChild(relieveState).gameObject;
    //relief = status.transform.GetChild(relieveState).gameObject;
    uiFill = relief.GetComponent<UIFill>();
   }
   void Update()
   {
    if(uiFill.isRelieving)
    {
         Timer += Time.deltaTime;
        if(Timer >= DelayAmount)
        {
            Timer = 0f;
            Add(plus);
        }
            print("You're a FUCKING Stud!");
    
    }
   }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            uiFill.isRelieving = true;
       
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            uiFill.isRelieving = false;
       
        }
    }
    void Add(double i)
    {
        uiFill.currentValue+= i;
        if(uiFill.currentValue > uiFill.maxValue)
        {
        uiFill.currentValue = uiFill.maxValue;
        }

        if(uiFill.currentValue >= uiFill.maxValue/2 )
        {
            uiFill.meterImg.sprite = uiFill.img0;
        }
        else if(uiFill.currentValue >= uiFill.maxValue/4 )
        {
            uiFill.meterImg.sprite = uiFill.img1;
        }
        else
        {
            uiFill.meterImg.sprite = uiFill.img2;
        }
        uiFill.fill.fillAmount = (float)uiFill.currentValue / uiFill.maxValue; 

    
    }
}
