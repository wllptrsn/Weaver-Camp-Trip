using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterMap : MonoBehaviour
{
    public GameObject newMap;
    public GameObject oldMap;
    //Beach's current Location is 526.7, -139.9,-12.11392
    public Vector3 mapLoc;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(newMap, mapLoc, Quaternion.identity);
    }
}
