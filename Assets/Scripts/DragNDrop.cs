using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNDrop : MonoBehaviour
{
    Vector2 difference = Vector2.zero;
    private Camera cam;
    private float gravScale;
    [SerializeField] private bool dragged;
    [SerializeField] private bool isInTheBag = false;

    private void Start()
    {
        gravScale = GetComponent<Rigidbody2D>().gravityScale;
        cam = GameObject.FindGameObjectWithTag("Camera").GetComponent<Camera>();
    }
    private void OnMouseDown()
    {
        difference = (Vector2)cam.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
        dragged = true;
        GetComponent<Rigidbody2D>().gravityScale = 0;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        //isInTheBag = false;
       
    }

    private void OnMouseDrag()
    {
        transform.position = (Vector2)cam.ScreenToWorldPoint(Input.mousePosition) - difference;
    }
    private void OnMouseUp()
    {
        
        if (isInTheBag)
        {
            dragged = false;
        }
        else
        {
            dragged = false;
            if (transform.parent.name != "CollectingItems")
            {
                transform.SetParent(GameObject.FindWithTag("CollectingItems").transform);
            }
            GetComponent<Rigidbody2D>().gravityScale = gravScale;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }

    public bool IsDragged()
    {
        
        return dragged;
    }

    public bool IsInTheBag()
    {

        return isInTheBag;
    }

    public void SetInTheBag(bool bagState)
    {
        isInTheBag = bagState;
    }
}

