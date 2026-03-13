using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class shop : MonoBehaviour
{
    public float cost3 = 2;
    public TMP_Text cost3txt;
    public float cost2 = 4;
    public TMP_Text cost2txt;
    public float cost = 2;
    public TMP_Text costtxt;
    public Button food;
    public TMP_Text moneytxt;
    public float money;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moneytxt.text = "money: " + money;
        costtxt.text = "cost: " + cost;
        cost2txt.text = "cost: " + cost2;
        cost3txt.text = "cost: " + cost3;
    }

    // Update is called once per frame
    void Update()
    {
        moneytxt.text = "money: " + money;
    }
    public void Food()
    {
        if(money >= 2)
        {
            money = money - 2;
            Debug.Log("got food");
            moneytxt.text = "money: " + money;
            costtxt.text = "cost: " + cost;
            
        }
    }
    public void Tank()
    {
        if(money >= 4)
        {
            money = money - 4;
            moneytxt.text = "money: " + money;
            Debug.Log("got tank");
            cost2txt.text = "cost: " + cost2;
            
        }
    }
    public void Fish()
    {
        if(money >= 4)
        {
            money = money - 4;
            Debug.Log("got fish");
            cost3txt.text = "cost: " + cost3;
            moneytxt.text = "money: " + money;
        }
    }
    public void Sell()
    {
        money = money + 20;
    }

}
