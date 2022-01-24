using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationInTheWorld : MonoBehaviour
{

    [SerializeField] private Vector2 CurrentLocation;
    
    void SetCurLoc(Vector2 needset)
    {
        CurrentLocation = needset;
    }

    Vector2 GetCurLoc()
    {
        return CurrentLocation;
    }
    
    
}
