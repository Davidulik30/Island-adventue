using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackPackOpenClose : MonoBehaviour
{
    [SerializeField] private GameObject Inventory; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CloseNOpen()
    {
        if (Inventory.activeSelf==true)
        {
            Inventory.SetActive(false);
        }
        else
        {
            Inventory.SetActive(true);
        }
    }
}
