using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 

public class OpenCooler : MonoBehaviour
{


    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;

    public GameObject uiFind;

    public Sprite water;
    public Sprite beer;
    public Sprite chips;
    public Sprite empty;


    GameObject inventoryScreen;
    GameObject regScreen;
    GameObject inventorySlots;

    int slotValue;
    int[] fillCooler = {0,1,2,3};
    public bool[] slotsFill;
    public int[] slotsTake;
    bool addToCooler = true;
    protected float Timer;
    public StockCooler stockCooler;

    // Start is called before the first frame update
    void Awake()
    {
        uiFind = GameObject.Find("UI Canvas");
        inventoryScreen = uiFind.transform.GetChild(2).gameObject;
        regScreen = uiFind.transform.GetChild(0).gameObject;
        inventorySlots = inventoryScreen.transform.GetChild(2).gameObject;
        stockCooler = inventorySlots.GetComponent<StockCooler>();
        slotsTake = stockCooler.slotsTake;
        slotsFill = stockCooler.slotsFill;
        
    }
    void Update()
    {   
        Timer += Time.deltaTime;
        if(!addToCooler)
        {
            if (Timer >= 120)
            {
                addToCooler = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
        {
            //Could use other.GetComponent<Player>() to see if game object has a player component.
            //Tags work too. Maybe some players have different Script Components.

            if(other.tag == "Player")
            {
                inventoryScreen.SetActive(true);
                regScreen.SetActive(false);
                GameObject slot;
                Image slotImg;
                int firstSlot = Random.Range(0,10);
                if (addToCooler)
                {
                    for(int i = 0; i < fillCooler.Length;i++)
                        {
                            slot  = uiFind.transform.GetChild(2).GetChild(2).GetChild(i).gameObject;
                            slotImg = slot.GetComponent<Image>();
                            if(i == 0)
                                {
                                    slotValue = Random.Range(0,10);
                                        switch(slotValue)
                                        {
                                            case int j when j > 6:
                                            slotsFill[i]=false;
                                            break;
                                            case int j when j > 4:
                                            slotImg.sprite = water;
                                            slotsFill[i]=true;
                                            slotsTake[i] = 1;
                                            break;
                                            case int j when j > 2:
                                            slotImg.sprite = chips;
                                            slotsFill[i]=true;
                                            slotsTake[i] = 2;
                                            break;
                                            case int j:
                                            slotImg.sprite = beer;
                                            slotsFill[i]=true;
                                            slotsTake[i] = 3;
                                            break;
                                        }

                                }
                            else
                                {
                                    slotValue = Random.Range(0,10);
                                    if(slotsFill[i-1] == true)
                                    {
                                        switch(slotValue)
                                            {
                                                case int j when j > 6:
                                                slotsFill[i]=false;
                                                break;
                                                case int j when j > 4:
                                                slotImg.sprite = water;
                                                slotsFill[i]=true;
                                                slotsTake[i] = 3;
                                                break;
                                                case int j when j > 2:
                                                slotImg.sprite = chips;
                                                slotsFill[i]=true;
                                                slotsTake[i] = 3;
                                                break;
                                                case int j:
                                                slotImg.sprite = beer;
                                                slotsFill[i]=true;
                                                slotsTake[i] = 3;
                                                break;
                                            }

                                    }
                                    else
                                    {
                                        slotsFill[i]=false;
                                    }

                                }
                            if(!slotsFill[i])
                                {
                                    slotImg.sprite = empty;
                                    slotsTake[i] = 0;
                                }
                        }
                        Timer = 0f;
                        addToCooler = false;
                }
            }
        }
        
    private void OnTriggerExit2D(Collider2D other)
        {
                inventoryScreen.SetActive(false);
                regScreen.SetActive(true);
        }



}
