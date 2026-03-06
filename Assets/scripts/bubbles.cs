using UnityEngine;

public class bubbles : MonoBehaviour
{
    public float Spawninterval = 2.0f;
    public float Startdelay = 1.0f;
    public Vector3 bubblepoint = new Vector3(-6.91f, -3.38f, 0.45f);
    public GameObject bubble;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Spawnbubble", Startdelay, Spawninterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawnbubble()
    {
        Instantiate(bubble, bubblepoint, bubble.transform.rotation);
    }
}
