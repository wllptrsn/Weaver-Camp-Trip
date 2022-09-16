using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject person;
    public float smoothFactor;
    public Vector3 offset;
    //Declare variables for Scene Boundaries
    public int camMinX;
    public int camMinY;
    public int camMaxX;
    public int camMaxY;

    //Main Section Values for scene bounds
    void start(){
        
        camMinX = -250;
        camMinY = -97;
        camMaxX = 265;
        camMaxY = 100;
    }
    void Update()
    {
            if(person.transform.position.x > camMinX && person.transform.position.x < camMaxX)
            {
                if(person.transform.position.y > camMinY && person.transform.position.y < camMaxY)
                {
               Follow(); 
                }
                else{FollowX();}
            }
            else if (person.transform.position.y > camMinY && person.transform.position.y < camMaxY){FollowY();}
            
    }

    public void Follow()
    {
        transform.position = new Vector3(person.transform.position.x,person.transform.position.y,transform.position.z);
        Vector3 smoothPosition = Vector3.Lerp(transform.position,person.transform.position,smoothFactor*Time.fixedDeltaTime);
        transform.position = smoothPosition;
        
    }
    public void FollowX()
    {
        transform.position = new Vector3(person.transform.position.x,transform.position.y,transform.position.z);
        Vector3 smoothPosition = Vector3.Lerp(transform.position,person.transform.position,smoothFactor*Time.fixedDeltaTime);
        transform.position = smoothPosition;
        
    }
    public void FollowY()
    {
        transform.position = new Vector3(transform.position.x,person.transform.position.y,transform.position.z);
        Vector3 smoothPosition = Vector3.Lerp(transform.position,person.transform.position,smoothFactor*Time.fixedDeltaTime);
        transform.position = smoothPosition;
        
    }
}

