using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSettings : MonoBehaviour
{
   //Menu States
   //public enum MenuStates {Reg, Sett};
   //public MenuStates currentState;
   public GameObject regScreen;
   public GameObject settingsScreen;
   public GameObject inventory;

   //When script first starts
   void Start()
   {
        OnReg();
   }

   public void OnSettings()
   {
        settingsScreen.SetActive(true);
        regScreen.SetActive(false);
        inventory.SetActive(false);
   }
   public void OnReg()
   {
        regScreen.SetActive(true);
        settingsScreen.SetActive(false);
        inventory.SetActive(false);
   }
   public void OnInventory()
   {
        regScreen.SetActive(true);
        settingsScreen.SetActive(false);
        inventory.SetActive(true);
   }
}
