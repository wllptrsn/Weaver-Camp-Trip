using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGGameManager : MonoBehaviour
{
    // Static variables belong to class itself not instance of class sp only one version exsists in memory.
    public static RPGGameManager sharedInstance = null;
    public GameObject uiControls;
    void Awake(){
        //Double checks that there aren't other instances of the prefab running.running
        if(sharedInstance != null && sharedInstance != this)
        {
            //if shared instance is instantiated and not equal to the current instance destroy it.
            Destroy(gameObject);
        }
        //If this is the only instance of sharedInstance then assign it to the current object
        else{
            sharedInstance=this;
        }
    }
    void Start(){
        //Consolidate all of the logic to set up scene in a regular method.
        SetUpScene();
    }
    public void SetUpScene(){
        Instantiate(uiControls, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
