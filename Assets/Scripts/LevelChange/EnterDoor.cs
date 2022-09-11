using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDoor : MonoBehaviour
{
    public int sceneBuildIndex;
    public GameObject UserInt;
    //This code creates a new variable for player position
    public Vector2 playerPosition;
    public VectorValue playerStorage;


    //Level move zoned enter if collider is a player.
    //Move game to an other scene.
    private void OnTriggerEnter2D(Collider2D other){
        print("Oh Joy!");
        //Could use other.GetComponent<Player>() to see if game object has a player component.
        //Tags work too. Maybe some players have different Script Components.
        if(other.tag == "Player"){
            playerStorage.initialValue = playerPosition;
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);

            UserInt = GameObject.Find("UI Canvas");
            DontDestroyOnLoad(UserInt);  

        }
    }
}