using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Drag : MonoBehaviour
{
    bool startDrag, inUse;
    Vector2 startPos, slotPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (startDrag)
        {
            transform.position = Input.mousePosition;
        }
    }

    public void StartDragUI()
    {
        startDrag = true;
    }

    public void StopDragUI()
    {
        startDrag = false;

        if (inUse)
        {
            transform.position = slotPos;
        }
        else
        {
            transform.position = startPos;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Slot"))
        {
            inUse = true;
            slotPos = collision.transform.position;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Slot"))
        {
            inUse = false;
        }
    }
}
