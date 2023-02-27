using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMapSound : MonoBehaviour
{
    void SmallShip()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
    void ShipSound()
    {
        SoundManager.isPlaneSound = true;
    }
    void ShipSoundOff()
    {
        SoundManager.isPlaneStop = true;
    }

    void LowShip()
    {
        SoundManager.is70ShipSound = true;
    }

    void SeagulSound()
    {
        SoundManager.isSeagul = true;
    }
    void SeagulSoundOff()
    {
        SoundManager.isSeagulStop = false;
    }

    void TruckSound()
    {
        SoundManager.isEngineSound = true;
    }

    void MarketSound()
    {
        SoundManager.isTree = true;
    }

    void ClickSound()
    {
        SoundManager.isClick= true;
    }
}
