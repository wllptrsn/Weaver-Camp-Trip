/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject person;
    public float smoothFactor;
    public Vector3 offset;
    int[][] cameraBounds = new int[2][]{
        //Main Area Coordinates
        //{xmin,ymin,xmax,ymax}
                new int[4]{-270,-116,250,95},
        //Main Cabin Coordinates
                new int[4]{-400,100,-300,127}
            };

    
    void Update()
    {
        for(int i = 0; i< cameraBounds.Length; i ++)
        {
            print("phew");
            if(person.transform.position.x > cameraBounds[i][0] && person.transform.position.x < cameraBounds[i][2])
            {
                if(person.transform.position.y > cameraBounds[i][1] && person.transform.position.y < cameraBounds[i][3])
                {
               Follow(); 
                }
                else{
                    FollowX(); 
                }
            }
            else if(person.transform.position.y > cameraBounds[i][1] && person.transform.position.y < cameraBounds[i][3])
            {
                FollowY();
            }
        }
            
    }

    void Follow()
    {
        transform.position = new Vector3(person.transform.position.x,person.transform.position.y,transform.position.z);
        Vector3 smoothPosition = Vector3.Lerp(transform.position,person.position,smoothFactor*Time.fixedDeltaTime);
        transform.position = smoothPosition;
        
    }
    void FollowX()
    {
        transform.position = new Vector3(person.transform.position.x,transform.position.y,transform.position.z);
        Vector3 smoothPosition = Vector3.Lerp(transform.position,person.position,smoothFactor*Time.fixedDeltaTime);
        transform.position = smoothPosition;
        
    }
    void FollowY()
    {
        transform.position = new Vector3(transform.position.x,person.transform.position.y,transform.position.z);
        Vector3 smoothPosition = Vector3.Lerp(transform.position,person.transform.position,smoothFactor*Time.fixedDeltaTime);
        transform.position = smoothPosition;
        
    }
}

*/