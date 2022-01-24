using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaWavesScr : MonoBehaviour
{
    [SerializeField] private GameObject[] WaveItems;
    
    
    void UpdateSea(float windspeed,float waveAmplitudeX, float waveAmplitudeY)
    {
        foreach (var wave in WaveItems)
        {
            wave.GetComponent<WaveBehaveScr>().Sliding(windspeed, waveAmplitudeX, waveAmplitudeY);
        }
    }
}
