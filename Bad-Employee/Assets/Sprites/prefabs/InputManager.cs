using UnityEngine;
using System.Collections;
public class InputManager : MonoBehaviour
{
    private bool draggingItem = false;
    public GameObject draggedObject;
    private Vector2 touchOffset;

    void Update()
    {
        if (HasInput)
        {
            DragOrPickUp();
        }
        else
        {
            if (draggingItem)
                DropItem();
        }
    }

    Vector2 CurrentTouchPosition
    {
        get
        {
            Vector2 inputPos;
            inputPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            return inputPos;
        }
    }

    private void DragOrPickUp()
    {
        var inputPosition = CurrentTouchPosition;
       
        if (draggingItem)
        {
            draggedObject.transform.position = inputPosition + touchOffset;
        }
        else
        {
            RaycastHit2D[] touches = Physics2D.RaycastAll(inputPosition, inputPosition, 0.5f);
            if (touches.Length > 0)
            {
                var hit = touches[0];
                if (hit.transform != null)
                {
                    if (hit.transform.tag == "box" || hit.transform.tag == "losebox" || hit.transform.tag == "mysterybox" || hit.transform.tag == "bonus")
                    {
                        draggingItem = true;
                        draggedObject = hit.transform.gameObject;
                        touchOffset = (Vector2)hit.transform.position - inputPosition;
                        draggedObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

                    }
                }
            }
        }
    }

    private bool HasInput
    {
        get
        {
            // returns true if either the mouse button is down or at least one touch is felt on the screen
            
                return Input.GetMouseButton(0);
            
           
        }
    }

    void DropItem()
    {
        draggingItem = false;
        draggedObject.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
    }
}