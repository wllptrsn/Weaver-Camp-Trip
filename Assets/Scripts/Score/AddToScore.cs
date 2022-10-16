using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToScore : MonoBehaviour
{
   public GameObject uiFind;
   public GameObject scoreKeeper;
   public PlayerScore playerScore;
   public int plusScore;
    // Start is called before the first frame update
    void Awake()
    {
        uiFind= GameObject.Find("UI Canvas");
        scoreKeeper = uiFind.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(0).gameObject;
        playerScore = scoreKeeper.GetComponent<PlayerScore>();
        plusScore = Random.Range(1,4);
    }
    void PlusScore(int i)
    {
        playerScore.scr = playerScore.scr + i;
    }

    private void OnTriggerEnter2D(Collider2D other){
        print("Talk to me Baby");
        //Could use other.GetComponent<Player>() to see if game object has a player component.
        //Tags work too. Maybe some players have different Script Components.
        if(other.tag == "Player"){
           if(plusScore == 1){PlusScore(10);}
           else if(plusScore == 2){PlusScore(20);}
           else if(plusScore == 3){PlusScore(30);}
           else if(plusScore == 4){PlusScore(40);}
        }
    }
        
}
