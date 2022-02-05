using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingStart : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "collectable")
        {
            

            if (collision.GetComponent<itemGrab>()==null)
                collision.gameObject.AddComponent<itemGrab>();

               collision.GetComponent<itemGrab>().StarCollecting(GetComponent<Transform>(), true, 1);
            
             
        }
    }
    public void AddItemToInventory(string itemName)
    {
        print(itemName);  
    }
   
    
}
