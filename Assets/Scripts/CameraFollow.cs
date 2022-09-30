using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject person;
    public float smoothFactor;
    public Vector3 offset;
    //Declare variables for Scene Boundaries
    public Vector2 minValue;
    public Vector2 maxValue;

    //Declare variables for Entrance Boundaries
    public int entranceMinX;
    public int entranceMaxX;

    //Main Section Values for scene bounds
    void start(){
        entranceMinX = -372;
        entranceMaxX = -360;
    }
    void Update()
    {

           
            if(person.transform.position.x > minValue.x && person.transform.position.x < maxValue.x)
            {    //Check if Character is in the range of the entrance
                if(person.transform.position.x > entranceMinX && person.transform.position.x < entranceMaxX)
                {
                    if(person.transform.position.y < minValue.y)
                    {
                        Follow(person.transform.position.x,minValue.y);
                        }
                    else if (person.transform.position.y < maxValue.y)
                    {
                        Follow(person.transform.position.x,person.transform.position.y);
                        }
                    else
                    {
                        Follow(person.transform.position.x,transform.position.y);
                    }
                }
                else if(person.transform.position.y > minValue.y && person.transform.position.y < maxValue.y)
                {
               Follow(person.transform.position.x,person.transform.position.y); 
                }
                else
                {
                    Follow(person.transform.position.x,transform.position.y);
                    }
            }
            else if (person.transform.position.y > minValue.y && person.transform.position.y < maxValue.y)
            {
                Follow(transform.position.x,person.transform.position.y);
                }
            
    }

    public void Follow(float x, float y)
    {
        transform.position = new Vector3(x,y,transform.position.z);
        Vector3 smoothPosition = Vector3.Lerp(transform.position,person.transform.position,smoothFactor*Time.fixedDeltaTime);
        transform.position = smoothPosition;
        
    }
}

