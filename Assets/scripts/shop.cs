using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class shop : MonoBehaviour
{
    public GameObject[] decpefabs;
    public bool helpBool = false;
    public bool startm = true;
    public fish fishscript;
    public GameObject[] sceneprefabs;
    public int totalValues;
    public GameObject[] fishPrefabs;
    public int fishcost = 30;

    public bool fishmenuact = false;
    public GameObject fishmenu;
    public GameObject bubble;
    public GameObject tank;
    public int size = 0;
    public int maxsize = 555;
    public float camincrease = 0.2f;
    public float camsize;
    public float currsize = 1f;
    public Camera cam;
    public GameObject Tank1;
    public float spawnY = 4.36f; 
    public Vector2 spawnRangeX = new Vector2(-8.34f, 8.34f); // X-axis spawn range
    public GameObject food1;
    public GameObject food2;
    public float cost3 = 1000;
    public TMP_Text cost3txt;
    public float cost2 = 10;
    public TMP_Text cost2txt;
    public float cost = 4;
    public float cost4 = 8;
    public TMP_Text cost4text;
    public TMP_Text costtxt;
    public TMP_Text moneytxt;
    public TMP_Text controls;
    public GameObject help;
    public int money = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camsize = cam.GetComponent<Camera>().orthographicSize;
        moneytxt.text = "$ " + money;
        costtxt.text = "fish Food: " + cost;
        cost4text.text = "fishco food: " + cost4;
        cost2txt.text = "Tank cost: " + cost2;
        cost3txt.text = "fish";
        controls.text = " press k when on a fish to sell alteratively you can press the sell all button to sell all of the fish in the tank / use wasd to move the camera   (' )<";
        fishmenu.SetActive(fishmenuact);
        fishscript = FindFirstObjectByType<fish>().GetComponent<fish>();
        money = money + 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            money = money + 10;
        }
        moneytxt.text = "$ " + money;
        sceneprefabs = GameObject.FindGameObjectsWithTag("fish");
        totalValues = 0;
        if(startm == true)
        {
            money = 40;
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
        if(money >= 4)
        {
            if(startm == false)
            {
                money = money - 4;
                Spawnfood();
                moneytxt.text = "money: " + money;
                costtxt.text = "Food cost: " + cost;
            }
        }
    }
    public void Food2()
    {
        if(money >= 8)
        {
            if(startm == false)
            {
                money = money - 8;
                Spawnfood2();
                moneytxt.text = "money: " + money;
                cost4text.text = "fishco cost: " + cost4;
            }
        }
    }
    public void Tank() 
    {
        if(money >= 10)
        {
            if(startm == false)
            {
                if(size <= maxsize)
                {
                    size += 1;
                    money = money - 10;
                    moneytxt.text = "money: " + money;
                    currsize += 0.1f;
                    Tank1.transform.localScale=new Vector3(currsize,currsize,currsize);
                    camsize += camincrease;
                    cam.GetComponent<Camera>().orthographicSize = camsize;
                    cost2txt.text = "Tank cost: " + cost2;
                }
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
    void Spawnfood2()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        
        Instantiate(food2, spawnPosition , food2.transform.rotation);
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
    public void DecBuy(int index)
    {
        if(startm == false)
        {
            if (decpefabs == null || index < 0 || index >= decpefabs.Length) return;
            if (decpefabs[index] == null) return;
 
            if (fishcost <= money)
            {
                money = money - fishcost;
                float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
                Vector2 spawnPosition = new Vector2(randomX, spawnY);
                Instantiate(decpefabs[index], spawnPosition, decpefabs[index].transform.rotation);
            }
        }
        
    }
    public void Help()
    {
        if(help != null)
        {
            helpBool = !helpBool;
            help.SetActive(helpBool);
        }

    }
}




    

    

