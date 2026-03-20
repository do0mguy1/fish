using UnityEngine;

public class tailfollow : MonoBehaviour
{
    public Vector3 swordoffset = new Vector3(1, 0, 0);
    public GameObject blue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = blue.transform.position + swordoffset;
    }
}
