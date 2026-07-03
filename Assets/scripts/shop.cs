using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class shop : MonoBehaviour
{
    public bool startm = true;
    public fish fishscript;
    public GameObject[] sceneprefabs;
    public int totalValues;
    public GameObject[] fishPrefabs;
    public int fishcost;

    public bool fishmenuact = false;
    public GameObject fishmenu;
    public GameObject bubble;
    public GameObject tank;
    public int size = 0;
    public int maxsize = 470;
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
    public int money = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camsize = cam.GetComponent<Camera>().orthographicSize;
        moneytxt.text = "fishcoins: " + money;
        costtxt.text = "Food cost: " + cost;
        cost2txt.text = "Tank cost: " + cost2;
        cost3txt.text = "fish";
        fishmenu.SetActive(fishmenuact);
        fishscript = FindFirstObjectByType<fish>().GetComponent<fish>();
        money = money + 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            money = money + 10;
        }
        moneytxt.text = "money: " + money;
        sceneprefabs = GameObject.FindGameObjectsWithTag("fish");
        totalValues = 0;
        if(startm == true)
        {
            money = 10;
        }

        foreach (GameObject prefab in sceneprefabs)
        {

            fish indFish = prefab.GetComponent<fish>();
            if(indFish != null)
            {
                totalValues += indFish.fishvalue;
            }
        }
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
    public void Sell(int fishPrise)
    {
        money = money + fishPrise;
    }
    public void Sellall(int fishPrise)
    {
        money = money + totalValues;
        foreach (GameObject prefab in sceneprefabs)
        {
            Destroy(prefab);
        }

    }
    void Spawnfood()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(food1, spawnPosition , food1.transform.rotation);
    }
    public void FishBuy(int index)
    {
        startm = false;
        if (fishPrefabs == null || index < 0 || index >= fishPrefabs.Length) return;
        if (fishPrefabs[index] == null) return;
 
        if (fishcost <= money)
        {
            money = money - fishcost;
            float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
            Vector2 spawnPosition = new Vector2(randomX, spawnY);
            Instantiate(fishPrefabs[index], spawnPosition, fishPrefabs[index].transform.rotation);
        }
    }
   
}




    

    

