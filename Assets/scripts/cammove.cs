using UnityEngine;

public class cammove : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D pr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.W))
        {
            pr.AddRelativeForce(Vector3.up * speed);
        }
        if(Input.GetKey(KeyCode.A))
        {
            pr.AddRelativeForce(Vector3.left * speed);
        }
        if(Input.GetKey(KeyCode.S))
        {
            pr.AddRelativeForce(Vector3.down * speed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            pr.AddRelativeForce(Vector3.right * speed);
        }
    }
}
