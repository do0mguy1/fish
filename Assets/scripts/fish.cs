using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class fish : MonoBehaviour
{
    public int fishvalue;
    public GameObject sellFish;
    public GameObject sellText;
    private GameObject selltextChild; 
    public bool cansell = false;
    public bool havehugner = true;

    public float growspeed;
    public float hugner = 100;
    private float fishmovetimer;
    private float hugnertimer;
    private float growtimer;
    public float movetick = 0.2f;
    public float hugnertick = 12f;
    public float growrate = 15f;
    public float speed = 15;
    public float lrspeed = 20;
    public float maxgrowsize = 5.0f;

    public Rigidbody2D playerrb;
    private SpriteRenderer render;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        fishmovetimer += Time.deltaTime;
        hugnertimer += Time.deltaTime;
        growtimer += Time.deltaTime;
        if (fishmovetimer >= movetick)
        {
            int randomNumber = Random.Range(0, 4);
            fishmovetimer = 0f;

            if (randomNumber == 0)
            {
                playerrb.AddRelativeForce(Vector3.up * speed);
                Debug.Log("w");
            }

            if (randomNumber == 1)
            {
                playerrb.AddRelativeForce(Vector3.left * lrspeed);
                Debug.Log("a");
                render.flipX = true;
            }

            if (randomNumber == 2)
            {
                playerrb.AddRelativeForce(Vector3.right * lrspeed);
                Debug.Log("d");
                render.flipX = false;
            }

            if (randomNumber == 3)
            {
                playerrb.AddRelativeForce(Vector3.down * speed);
                Debug.Log("s");
            }
        }
        if(havehugner == true)
        {
            if (hugnertimer >= hugnertick)
            {
                hugnertimer = 0f;
                hugner = hugner - 5;
            }
        }
        if(growtimer >= growrate)
        {
            growtimer = 0f;
            if(transform.localScale.x < maxgrowsize)
            {
                transform.localScale += Vector3.one * growspeed;
                fishvalue = fishvalue + 10;
            }
        }
        if(transform.localScale.x >= maxgrowsize && !cansell)
        {
            SpawnSellFish();
        }
    }
    void SpawnSellFish()
    {
      cansell = true; 
      Vector3 fishPos = transform.position + new Vector3(0, 2.0f, 0);
      GameObject sellFishChild = Instantiate(sellFish, fishPos, Quaternion.identity);
      sellFishChild.transform.SetParent(this.transform);
      sellFishChild.transform.localScale = Vector3.one;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("food"))
        {
            Destroy(collision.gameObject);
            hugner = hugner + 20;
            fishvalue = fishvalue + 5;
        }
         if(collision.gameObject.CompareTag("food2"))
        {
            Destroy(collision.gameObject);
            hugner = hugner + 40;
            fishvalue = fishvalue + 10;
        }
    }

    public void OnMouseEnter()
    {
        if(selltextChild == null)
        {
            //Vector3 fishPos = transform.position + new Vector3(0, -0.5f, 0);
            Renderer objectRenderer = GetComponent<Renderer>();
            float bottomY = objectRenderer.bounds.min.y;
            float spaceFish = -0.5f; // Adjust this to push it slightly lower than the edge
            Vector3 fishPos = new Vector3(transform.position.x, bottomY + spaceFish, transform.position.z);
            selltextChild = Instantiate(sellText, fishPos, Quaternion.identity);
            selltextChild.transform.SetParent(this.transform);
            TMP_Text text = selltextChild.GetComponentInChildren<TMP_Text>();

            if(text != null)
            {
                text.text = fishvalue.ToString();
            }
        }
        
    }
    public void OnMouseExit()
    {
        if(selltextChild != null)
        {
            Destroy(selltextChild);
            selltextChild = null;
        }
    }
}
