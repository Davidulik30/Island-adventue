using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemGrab : MonoBehaviour
{
    // Start is called before the first frame update
    
    bool IsCollision = false;
    Transform PlayerPosition;
    public int NubmerToDestroy = 0;
    float LerpDeltaTime = 0;
    
    
    // Update is called once per frame
    void Update()
    {
        if (IsCollision)
        {
            transform.position = Vector2.Lerp(transform.position, PlayerPosition.position, LerpDeltaTime);
            LerpDeltaTime += Time.deltaTime / 10;
            if (NubmerToDestroy > 1)
            {
                PlayerPosition.gameObject.GetComponent<CollectingStart>().AddItemToInventory(this.name);
                Destroy(this.gameObject);
            }
        }
        
    }
    
    public void StarCollecting(Transform playerPosition, bool startLerp,int nubmerToDestroy)
    {
        if (nubmerToDestroy == 1)
            NubmerToDestroy++;

        IsCollision = startLerp;
        PlayerPosition = playerPosition;
    }
}
