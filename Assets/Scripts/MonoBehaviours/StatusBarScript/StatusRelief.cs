using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusRelief : MonoBehaviour
{

   public GameObject uiFind;
   public GameObject relief;
   public UIFill uiFill;
   public int relieveState;
   
   void Awake()
   {
    uiFind= GameObject.Find("UI Canvas");
    relief = uiFind.transform.GetChild(0).GetChild(relieveState).gameObject;
    //relief = status.transform.GetChild(relieveState).gameObject;
    uiFill = relief.GetComponent<UIFill>();
   } 
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            print("You're a FUCKING Stud!");
            uiFill.currentValue = uiFill.maxValue;
            uiFill.fill.fillAmount = (float)uiFill.currentValue / uiFill.maxValue;
        }
    }
}
