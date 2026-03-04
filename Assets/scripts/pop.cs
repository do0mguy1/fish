using UnityEngine;

public class pop : MonoBehaviour
{
    public GameObject bubbler;
    public Rigidbody2D bubble;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("point"))
        {
            Destroy(gameObject);
            Debug.Log("pop");
        }
    }
}
