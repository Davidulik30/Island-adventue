using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBagEnterTrigger : MonoBehaviour
{
    DragNDrop refOnScript;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Enter");
        if (collision.tag == "collectable")
        {
            refOnScript = collision.GetComponent<DragNDrop>();
            
            if (refOnScript.IsDragged()&&!refOnScript.IsInTheBag())
            {
                
                refOnScript.SetInTheBag(true);
                
                collision.gameObject.transform.parent=transform;
                collision.GetComponent <Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.tag == "collectable")
        {
            
            refOnScript = collision.GetComponent<DragNDrop>();
            
            if (refOnScript.IsDragged()&&refOnScript.IsInTheBag())
            {
               
                refOnScript.SetInTheBag(false);
                //collision.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            }
        }   
     }
}
