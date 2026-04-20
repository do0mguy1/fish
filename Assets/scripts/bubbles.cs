using UnityEngine;

public class bubbles : MonoBehaviour
{
    public float Spawninterval = 1.0f;
    public GameObject bubble;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Spawnbubble", Spawninterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawnbubble()
    {
        Instantiate(bubble, transform.position, transform.rotation);
        Invoke("Spawnbubble", Spawninterval);
    }
}
