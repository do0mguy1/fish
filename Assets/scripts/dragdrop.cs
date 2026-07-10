using UnityEngine;

public class dragdrop : MonoBehaviour
{
    public bool ispickedup;
    Vector3 bounds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bounds = Camera.main.ViewportToWorldPoint(new Vector3(1,1,Camera.main.nearClipPlane));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -bounds.x + transform.localScale.x / 2)
        {
            transform.position = new Vector3(-bounds.x + transform.localScale.x / 2, transform.position.y, transform.position.z);
        }
 
        if (transform.position.x > bounds.x - transform.localScale.x / 2)
        {
            transform.position = new Vector3(bounds.x - transform.localScale.x / 2, transform.position.y, transform.position.z);
        }
 
        if (transform.position.y < -bounds.y + transform.localScale.y / 2)
        {
            transform.position = new Vector3(transform.position.x, -bounds.y + transform.localScale.x / 2, transform.position.z);
        }
 
        if (transform.position.y > bounds.y - transform.localScale.x / 2)
        {
            transform.position = new Vector3(transform.position.x, bounds.y - transform.localScale.x / 2, transform.position.z);
        }
 
        if(ispickedup)
        {
            GetComponent<TargetJoint2D>().enabled = true;
            Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GetComponent<TargetJoint2D>().target = mousepos;

            if(Input.GetMouseButtonUp(0))
            {
                GetComponent<TargetJoint2D>().enabled = false;
                ispickedup = false;
            }
        }
    }
    private void OnMouseDown()
    {
        
        
        if(Input.GetMouseButtonDown(0))
        {
            ispickedup = true;
        }
    }
}
