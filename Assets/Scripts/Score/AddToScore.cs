using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToScore : MonoBehaviour
{
    public GameObject uiFind;
    public GameObject scoreKeeperMain;
    public GameObject scoreKeeperSettings;
    public PlayerScore playerScore;
    public PlayerScore playerScoreSettings;
    bool wantsToTalk = true;
    public int plusScore;
    protected float Timer;
    // Start is called before the first frame update
    void Awake()
    {
        uiFind= GameObject.Find("UI Canvas");
        scoreKeeperMain = uiFind.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).gameObject;
        scoreKeeperSettings = uiFind.transform.GetChild(1).GetChild(1).GetChild(2).GetChild(1).gameObject;
        playerScore = scoreKeeperMain.GetComponent<PlayerScore>();
        playerScoreSettings = scoreKeeperSettings.GetComponent<PlayerScore>();
        plusScore = Random.Range(1,5);
    }
    void PlusScore(int i)
    {
        playerScore.scr = playerScore.scr + i;
        playerScoreSettings.scr = playerScoreSettings.scr +i;
        wantsToTalk = false;
        Timer = 0f;
    }
    void Update()
    {   
        Timer += Time.deltaTime;
        if(!wantsToTalk)
        {
            if (Timer >= 40)
            {
                wantsToTalk = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        //Could use other.GetComponent<Player>() to see if game object has a player component.
        //Tags work too. Maybe some players have different Script Components.

        if(other.tag == "Player"){
            if(wantsToTalk)
            {
                if(plusScore == 1){PlusScore(10);print("Yeah. Hey. Whatever.");}
                else if(plusScore == 2){PlusScore(20);print("How are you.");}
                else if(plusScore == 3){PlusScore(30);print("Oh My God! Hi!!");}
                else if(plusScore == 4){PlusScore(80);print("Oh my God. It's been forever!!!");}

            }
        }
    }
        
}
