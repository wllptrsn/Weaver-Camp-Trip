using UnityEngine;
using UnityEngine.UI;

public class UIFill : MonoBehaviour
{     
        public int maxValue;
        public Image fill;
        public Sprite img0;
        public Sprite img1;
        public Sprite img2;
        public GameObject uiParent;
        public GameObject uiMeter;
        public Image meterImg;
        public double currentValue;
        protected float Timer;
        public int DelayAmount=1;
        public double minus;
        public bool isRelieving = false;
        public int relieveState;
    // Start is called before the first frame update
    void Start()
    {
        currentValue = Random.Range(6f,10f);
        fill.fillAmount = (float)currentValue / maxValue;
    }
    void Awake()
    {
        uiParent= GameObject.Find("UI Canvas");
        uiMeter = uiParent.transform.GetChild(0).GetChild(0).GetChild(relieveState).GetChild(0).GetChild(0).gameObject;
        meterImg = uiMeter.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (!isRelieving){
        Timer += Time.deltaTime;
        //if (Input.GetKeyDown(KeyCode.D))
        //Deduct(minus);
        if(Timer >= DelayAmount){
            Timer = 0f;
            Deduct(minus);
        }

        }
    }
    public void Deduct(double i){
        currentValue -=i;
        if(currentValue < .5)
        {
            currentValue = .5;
        }
        fill.fillAmount = (float)currentValue / maxValue;

        if(currentValue >= maxValue/2 )
        {
            meterImg.sprite = img0;
        }
        else if(currentValue >= maxValue/3 )
        {
            meterImg.sprite = img1;
        }
        else
        {
            meterImg.sprite = img2;
        }
        

    
    }
    //p170 
}
