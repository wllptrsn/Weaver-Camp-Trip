/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public BathroomBar bathroomBarPrefab;
    BathroomBar bathroomBar;
    // Start is called before the first frame update
    void Start()
    {
        statusBarPoints.value=startingStatusBarPoints;
        ///bathroomBar = Instantiate(bathroomBarPrefab);
        bathroomBar.character = this;
    }
    void Update()
    {
    }
    //p170 
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Bathroom"))
        {
            statusBarPoints.value = maxStatusBarPoints;
        }
    }
}
*/
