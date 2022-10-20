using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndoorCreate : MonoBehaviour
{

    public GameObject person;

    public GameObject[] items = new GameObject[7];
    public int[] itemsCreate = new int[7];
    public Vector2[] itemsLocation = new Vector2[7];
    public int[] minRange = new int[7];

    public List<GameObject> ObjectsInRoom = new List<GameObject>();
    public GameObject ActiveObj;

    public Vector2 MinBounds;
    public Vector2 MaxBounds;


    public Vector2 MinBounds2;
    public Vector2 MaxBounds2;
    
    public bool hasBeenCreated = false;

    void Start()
    {
        randomnumberCreate();
        
    }
    void Update()
    {
        if(person.transform.position.x < MinBounds.x || person.transform.position.y < MinBounds.y || person.transform.position.x > MaxBounds.x || person.transform.position.y > MaxBounds.y)
            {
                if(person.transform.position.x < MinBounds2.x || person.transform.position.y < MinBounds2.y || person.transform.position.x > MaxBounds2.x || person.transform.position.y > MaxBounds2.y)
                {
                        for (int i=0; i<ObjectsInRoom.Count;i++)
                    {
                        Destroy(ObjectsInRoom[i]);
                    }
                    hasBeenCreated = false;
                    randomnumberCreate();
                }
            }

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(!hasBeenCreated)
            {
                    //if(bed1Create == 10){ActiveObj = Instantiate(items[0],itemsLocation[0],Quaternion.identity);}
                    for(int i = 0; i < items.Length-1;i++)
                    {
                        if(itemsCreate[i] >8){ActiveObj = Instantiate(items[i],itemsLocation[i],Quaternion.identity);}
                        ObjectsInRoom.Add(ActiveObj);
                    }
                hasBeenCreated = true;
            }
        }

    }
    public void randomnumberCreate()
    {
        for(int i = 0; i<itemsCreate.Length-1;i++)
            {
                itemsCreate[i] = Random.Range(minRange[i],10);
            }
    }

    
}