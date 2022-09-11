/*using UnityEngine;
using UnityEngine.UI;

public class BathroomBar : MonoBehaviour
{
    public StatusBarPoints statusBarPoints;
    [HideInInspector]
    public Player character;
    public Image meterImage;
    float maxStatusBarPoints;

    // Start is called before the first frame update
    void Start()
    {
        maxStatusBarPoints = character.maxStatusBarPoints;
    }

    // Update is called once per frame
    void Update()
    {
        if(character != null)
        {
            meterImage.fillAmount = statusBarPoints.value / maxStatusBarPoints;
        }
    }
}*/
