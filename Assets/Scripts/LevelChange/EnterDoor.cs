using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnterDoor : MonoBehaviour
{
    public Vector2 playerPosition;
    public GameObject person;

    public GameObject CheckCam;
    public GameObject status;
    public CameraFollow cameraFollow;

    public Vector2 minVal;
    public Vector2 maxVal;
    /*public int minX;
    public int minY;
    public int maxX;
    public int maxY;*/

    public int doorMinX;
    public int doorMaxX;

    void Awake()
    {
       //Find Cameras Game Object
       CheckCam = GameObject.Find("Cameras");
       //Find camera inside Cameras Game Object
       status = CheckCam.transform.GetChild(0).gameObject;
       //Find Component of Camera Follow
       cameraFollow = status.GetComponent<CameraFollow>();
    }
    private void OnTriggerEnter2D(Collider2D other){
        print("Oh Joy!");
        //Could use other.GetComponent<Player>() to see if game object has a player component.
        //Tags work too. Maybe some players have different Script Components.
        if(other.tag == "Player"){
            person.transform.position = playerPosition;

        cameraFollow.minValue = minVal;
        cameraFollow.maxValue = maxVal;
        cameraFollow.entranceMinX = doorMinX;
        cameraFollow.entranceMaxX = doorMaxX;
        }

    }
}