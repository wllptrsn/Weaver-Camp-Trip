using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDoor : MonoBehaviour
{
    public Vector2 playerPosition;
    public GameObject person;

    public GameObject CheckCam;
    public GameObject status;
    public CameraFollow cameraFollow;

    public int minX;
    public int minY;
    public int maxX;
    public int maxY;
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

        cameraFollow.camMinX = minX;
        cameraFollow.camMinY = minY;
        cameraFollow.camMaxX = maxX;
        cameraFollow.camMaxY = maxY;
        }

    }
}