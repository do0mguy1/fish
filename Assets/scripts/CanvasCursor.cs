using UnityEngine;
using UnityEngine.UI;

public class CanvasCursor : MonoBehaviour
{
    public Image newcursor;
    public Sprite normalmouse;
    public Sprite clickmouse;
    private Vector2 offset = Vector2.zero;
    private Canvas canvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
        canvas = GetComponent<Canvas>();
        if(newcursor != null)
        {
            newcursor.sprite = normalmouse;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(newcursor == null) return;
        
        //image track mouse    
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvas.transform as RectTransform,
            Input.mousePosition,
            canvas.worldCamera,
            out Vector2 mousePos
        );

        newcursor.rectTransform.localPosition = mousePos + offset;
        //swaping sprits
        if(Input.GetMouseButtonDown(0))
        {
            newcursor.sprite = clickmouse;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            newcursor.sprite = normalmouse;
        }
    }
    void OnDisable()
    {
        Cursor.visible = true;
    }
}
