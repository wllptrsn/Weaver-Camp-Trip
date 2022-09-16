using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public GameObject UIBuild;
    public int sceneBuildIndex;
    public void playGame()
    {
        //Instantiate(UIBuild, new Vector3(0, 0, 0), Quaternion.identity)
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }
}
