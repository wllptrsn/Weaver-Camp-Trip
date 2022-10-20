using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 

public class TakeFromCooler : MonoBehaviour
{

    public int whichSlot;
    public StockCooler stockCooler;
    GameObject inventorySlots;
    GameObject inventoryScreen;
    public int[] slotsTake;
    public GameObject uiFind;
    public bool[] slotsFill;
    public Sprite empty;
    Image slotImg;
    GameObject slot;

    void Awake()
    {
        uiFind = GameObject.Find("UI Canvas");
        inventoryScreen = uiFind.transform.GetChild(2).gameObject;
        inventorySlots = inventoryScreen.transform.GetChild(2).gameObject;
        stockCooler = inventorySlots.GetComponent<StockCooler>();
        slotsTake = stockCooler.slotsTake;
        slotsFill = stockCooler.slotsFill;
        slot = uiFind.transform.GetChild(2).GetChild(2).GetChild(whichSlot).gameObject;
        slotImg = slot.GetComponent<Image>();
        
    }

    public void TakeItem()
    {
        switch(slotsTake[whichSlot])
        {
            case 1:
                DrinkWater();
            break;
            case 2:
                EatChips();
            break;
            case 3:
                DrinkBeer();
            break;
        }

    }
    public void DrinkWater()
    {
        print("drink Water");
        slotsTake[whichSlot] = 0;
        slotsFill[whichSlot] = false;
        slotImg.sprite = empty;
    }

    public void DrinkBeer()
    {
        print("drink Beer");
        slotsTake[whichSlot] = 0;
        slotsFill[whichSlot] = false;
        slotImg.sprite = empty;
    }

    public void EatChips()
    {
        print("eatChips");
        slotsTake[whichSlot] = 0;
        slotsFill[whichSlot] = false;
        slotImg.sprite = empty;
    }
}
