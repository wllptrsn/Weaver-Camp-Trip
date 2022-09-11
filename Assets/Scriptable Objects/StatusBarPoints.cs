using UnityEngine;

//CREATES AN ASSET IN THE "Create submenu which allows us to easily create instances of the Bathroom Points Scriptable Object
[CreateAssetMenu(menuName="BathroomPoints")]
public class StatusBarPoints : ScriptableObject
{
    //Use a float to hold the Bathrooom Points. We will assign a float to the meter value of the status bar
    public float value;
}