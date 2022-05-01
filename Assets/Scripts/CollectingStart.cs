using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingStart : MonoBehaviour
{
    [SerializeField] GameObject inventoryRef;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "collectable")
        {
            collision.GetComponent<itemGrab>().StarCollecting(false,0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "collectable")
        {


            if (collision.GetComponent<itemGrab>() == null)
            {
                collision.gameObject.AddComponent<itemGrab>();
            }

            
                collision.GetComponent<itemGrab>().StarCollecting(GetComponent<Transform>(), true, 1);
            

        }
    }
    public void AddItemToInventory(GameObject objToAdd)
    {
        objToAdd.GetComponent<Rigidbody2D>().gravityScale = 0;
        objToAdd.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        objToAdd.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        objToAdd.transform.position = inventoryRef.transform.position;
        objToAdd.GetComponent<DragNDrop>().SetInTheBag(true);
        objToAdd.transform.SetParent(inventoryRef.transform);  
    }
   
    
}
