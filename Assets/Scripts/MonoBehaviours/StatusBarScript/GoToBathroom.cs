using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToBathroom : MonoBehaviour
{
   public UIFill uiFill;
   public GameObject status;

   void Awake()
   {
    status= GameObject.Find("Bathroom");
    uiFill = status.GetComponent<UIFill>();
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
