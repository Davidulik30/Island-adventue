using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemGrab : MonoBehaviour
{
    // Start is called before the first frame update

    bool IsCollision = false;
    Transform PlayerPosition;
    [SerializeField]private int NubmerToDestroy = 0;
    float LerpDeltaTime = 0;
    // Update is called once per frame
    void Update()
    {
        if (IsCollision && Input.GetKey("e"))
        {
            transform.position = Vector2.Lerp(transform.position, PlayerPosition.position, LerpDeltaTime);
            LerpDeltaTime += Time.deltaTime / 10;

            if (NubmerToDestroy > 2)
            {
                PlayerPosition.gameObject.GetComponent<CollectingStart>().AddItemToInventory(this.gameObject);
               
            }
        }

    }

    public void StarCollecting(Transform playerPosition, bool startLerp, int nubmerToDestroy)
    {
        if (nubmerToDestroy > 0)
            NubmerToDestroy+=1;


        IsCollision = startLerp;

        PlayerPosition = playerPosition;
    }
    public void StarCollecting(bool startLerp, int nubmerToDestroy)
    {
        NubmerToDestroy = 0;
        IsCollision = startLerp;
    }
}
