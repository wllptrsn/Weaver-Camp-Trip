using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutdoorCreate : MonoBehaviour
{

    public GameObject randomobj1;
    public GameObject randomobj2;
    public GameObject randomobj3;
    public GameObject randomobj4;
    public GameObject randomobj5;
    public GameObject randomobj6;
    public GameObject ActiveObj;

    public int checkRandom;
    public GameObject person;
    public Vector2 MinBounds;
    public Vector2 MaxBounds;
    public Vector3 randomloc1;
    public Vector3 randomloc2;
    public Vector3 randomloc3;
    public Vector3 randomloc4;
    public Vector3 randomloc5;
    public Vector3 randomloc6;
    public bool hasBeenCreated = false;

    void Start()
    {
       checkRandom = Random.Range(0,10);
        
    }
    void Update()
    {
        if(person.transform.position.x < MinBounds.x || person.transform.position.y < MinBounds.y || person.transform.position.x > MaxBounds.x || person.transform.position.y > MaxBounds.y)
            {
                Destroy(ActiveObj);
                hasBeenCreated = false;
                checkRandom = Random.Range(0,10);
            }

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(!hasBeenCreated)
            {
                    switch(checkRandom)
                    {
                        case int i when i  > 7:
                            //Instantiate(randomobj1, randomloc1, Quaternion.identity);
                            ActiveObj = Instantiate(randomobj1,randomloc1,Quaternion.identity);
                            break;
                        case int i when i  > 5 && i <=7:
                            //Instantiate(randomobj2, randomloc2, Quaternion.identity);
                            ActiveObj = Instantiate(randomobj2,randomloc2,Quaternion.identity);
                            break;
                        case int i when i  > 4 && i <=5:
                            //Instantiate(randomobj3, randomloc3, Quaternion.identity);
                            ActiveObj = Instantiate(randomobj3,randomloc3,Quaternion.identity);
                            break;
                        case int i when i  > 3 && i <= 4:
                            //Instantiate(randomobj4, randomloc4, Quaternion.identity);
                            ActiveObj = Instantiate(randomobj4,randomloc4,Quaternion.identity);
                            break;
                        case int i when i  > 2 && i <=3:
                            //Instantiate(randomobj5, randomloc5, Quaternion.identity);
                            ActiveObj = Instantiate(randomobj5,randomloc5,Quaternion.identity);
                            break;
                        case int i when i  > 1 && i <=2:
                            //Instantiate(randomobj6, randomloc6, Quaternion.identity);
                            ActiveObj = Instantiate(randomobj6,randomloc6,Quaternion.identity);
                            break;
                    }
                hasBeenCreated = true;
            }
        }

    }
    
}
