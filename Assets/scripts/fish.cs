using UnityEngine;

public class fish : MonoBehaviour
{
    public float timer2;
    public float interval2 = 12f;
    public float hugner = 100;
    private SpriteRenderer render;
    public float timer;
    public float interval = 1f;
    public float speed = 15;
    public float lrspeed = 20;
    public Rigidbody2D playerrb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        if (timer >= interval)
        {
            int randomNumber = Random.Range(0, 4);
            timer = 0f;

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
        if (timer2 >= interval2)
        {
            timer2 = 0f;
            hugner = hugner - 5;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("food"))
        {
            Destroy(collision.gameObject);
        }
    }
}
