using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class shop : MonoBehaviour
{
    public GameObject fish1;public GameObject fish2;public GameObject fish3;public GameObject fish4;
    public GameObject fish5;public GameObject fish6;public GameObject fish7;public GameObject fish8;
    public GameObject fish9;public GameObject fish10;public GameObject fish11;public GameObject fish12;
    public GameObject fish13;public GameObject fish14;public GameObject fish15;public GameObject fish16;
    public GameObject fish17;public GameObject fish18;public GameObject fish19;public GameObject fish20;
    public GameObject fish21;public GameObject fish22;public GameObject fish23;public GameObject fish24;public GameObject fish25;
    public GameObject fish26;

    private fish fishScipt;
    private int fishValueSell;
    public bool fishmenuact = false;
    public GameObject fishmenu;
    public GameObject bubble;
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
    public TMP_Text moneytxt;
    public int money;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camsize = cam.GetComponent<Camera>().orthographicSize;
        moneytxt.text = "money: " + money;
        costtxt.text = "Food cost: " + cost;
        cost2txt.text = "Tank cost: " + cost2;
        cost3txt.text = "fish";
        fishmenu.SetActive(fishmenuact);
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
            costtxt.text = "Food cost: " + cost;
            cost2txt.text = "fish";
            
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
                camsize += camincrease;
                cam.GetComponent<Camera>().orthographicSize = camsize;
                cost2txt.text = "Tank cost: " + cost2;

            }
            if(size > maxsize)
            {
                    tank.SetActive(false);
            }
                

            
        }
    }
    public void Fish()
    {
        if(fishmenu != null)
        {
            fishmenuact = !fishmenuact;
            fishmenu.SetActive(fishmenuact);
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
    public void Fish1buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish1, spawnPosition , fish1.transform.rotation);
    }
    public void Fish2buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish2, spawnPosition , fish2.transform.rotation);
    }
    public void Fish3buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish3, spawnPosition , fish3.transform.rotation);
    }
    public void Fish4buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish4, spawnPosition , fish4.transform.rotation);
    }
    public void Fish5buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish5, spawnPosition , fish5.transform.rotation);
    }
    public void Fish6buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish6, spawnPosition , fish6.transform.rotation);
    }
    public void Fish7buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish7, spawnPosition , fish7.transform.rotation);
    }
    public void Fish8buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish8, spawnPosition , fish8.transform.rotation);
    }
    public void Fish9buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish9, spawnPosition , fish9.transform.rotation);
    }
    public void Fish10buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish10, spawnPosition , fish10.transform.rotation);
    }
    public void Fish11buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish11, spawnPosition , fish11.transform.rotation);
    }
    public void Fish12buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish12, spawnPosition , fish12.transform.rotation);
    }
    public void Fish13buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish13, spawnPosition , fish13.transform.rotation);
    }
    public void Fish14buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish14, spawnPosition , fish14.transform.rotation);
    }
    public void Fish15buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish15, spawnPosition , fish15.transform.rotation);
    }
    public void Fish16buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish16, spawnPosition , fish16.transform.rotation);
    }
    public void Fish17buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish17, spawnPosition , fish17.transform.rotation);
    }
    public void Fish18buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish18, spawnPosition , fish18.transform.rotation);
    }
    public void Fish19buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish19, spawnPosition , fish19.transform.rotation);
    }
    public void Fish20buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish20, spawnPosition , fish20.transform.rotation);
    }
    public void Fish21buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish21, spawnPosition , fish21.transform.rotation);
    }
    public void Fish22buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish22, spawnPosition , fish22.transform.rotation);
    }
    public void Fish23buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish23, spawnPosition , fish23.transform.rotation);
    }
    public void Fish24buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish24, spawnPosition , fish24.transform.rotation);
    }
    public void Fish25buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish25, spawnPosition , fish25.transform.rotation);
    }
    public void Fish26buy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(fish26, spawnPosition , fish26.transform.rotation);
    }
   
}
