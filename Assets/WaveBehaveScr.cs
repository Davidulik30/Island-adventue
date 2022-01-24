using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveBehaveScr : MonoBehaviour
{
    [SerializeField] private float Windspeed;
    [SerializeField] private float WaveAmplitudeX;
    [SerializeField] private float WaveAmplitudeY;
   
    public void Sliding(float windspeed, float waveAmplitudeX, float waveAmplitudeY)
    {
        Windspeed = windspeed;
        WaveAmplitudeX = waveAmplitudeX;
        WaveAmplitudeY = waveAmplitudeY;
    }

    
    void Update()
    {
        
    }
}
