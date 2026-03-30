using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class shop : MonoBehaviour
{
    public GameObject tank;
    public int size = 0;
    public int maxsize = 9;
    public float camincrease = 0.2f;
    public float camsize;
    public float currsize = 1f;
    public Camera cam;
    public GameObject Tank1;
    public float spawnY = 4.36f; 
    public Vector2 spawnRangeX = new Vector2(-8.34f, 8.34f); // X-axis spawn range
    public GameObject food1;
    public GameObject food2;
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
        camsize = cam.GetComponent<Camera>().orthographicSize;
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
            Spawnfood();
            moneytxt.text = "money: " + money;
            costtxt.text = "cost: " + cost;
            
        }
    }
    public void Tank() 
    {
        if(money >= 4)
        {        
            
            if(size <= maxsize)
            {
                size += 1;
                money = money - 4;
                moneytxt.text = "money: " + money;
                currsize += 0.1f;
                Tank1.transform.localScale=new Vector3(currsize,currsize,currsize);
                //cam.GetComponent<Camera>().orthographicSize;
                camsize += camincrease;
                cam.GetComponent<Camera>().orthographicSize = camsize;
                cost2txt.text = "cost: " + cost2;

            }
            if(size > maxsize)
            {
                    tank.SetActive(false);
            }
                

            
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
    void Spawnfood()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(food1, spawnPosition , food1.transform.rotation);
    }

}
