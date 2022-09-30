/*using System.Collections;
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

    //Declare variables for Entrance Boundaries
    public int entranceMinX;
    public int entranceMaxX;
    public int entranceMinY;
    public int entranceMaxY;

    //Main Section Values for scene bounds
    void start(){
        
        camMinX = -420;
        camMinY = -78;
        camMaxX = -311;
        camMaxY = 105;

        entranceMinX = -372;
        entranceMaxX = -360;
        entranceMinY = 60;
        entranceMaxY = 73;
    }
    void Update()
    {

           
            if(person.transform.position.x > camMinX && person.transform.position.x < camMaxX)
            {    //Check if Character is in the range of the entrance
                if(person.transform.position.x > entranceMinX && person.transform.position.x < entranceMaxX)
                {
                    if(person.transform.position.y >entranceMinY && person.transform.position.y < entranceMaxY){FollowEntrance();}
                    else if (person.transform.position.y < camMaxY){Follow();}
                }
                else if(person.transform.position.y > camMinY && person.transform.position.y < camMaxY)
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
    public void FollowEntrance()
    {
        transform.position = new Vector3(person.transform.position.x,camMinY,transform.position.z);
        Vector3 smoothPosition = Vector3.Lerp(transform.position,person.transform.position,smoothFactor*Time.fixedDeltaTime);
        transform.position = smoothPosition;
        
    }
}
*/
