using UnityEngine;
using UnityEngine.UI;

public class UIFill : MonoBehaviour
{
        public int maxValue;
        public Image fill;
        public int currentValue;
    // Start is called before the first frame update
    void Start()
    {
        currentValue = maxValue/2;
        fill.fillAmount = (float)currentValue / maxValue;;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        Add(1);
        if (Input.GetKeyDown(KeyCode.D))
        Deduct(1);
        
    }

    public void Add(int i)
    {
        currentValue +=i;
        if(currentValue > maxValue)
        {
            currentValue = maxValue;
        }
        fill.fillAmount = (float)currentValue / maxValue;

    }
    public void Deduct(int i){
        currentValue -=i;
        if(currentValue < 0)
        {
            currentValue = 0;
        }
        fill.fillAmount = (float)currentValue / maxValue;

    
    }
    //p170 
}
