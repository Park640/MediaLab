using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScoreSound : MonoBehaviour
{
    void CitySound()
    {
        if (!CityControll.isStart)
        {
            CityControll.isStart = true;
        }

    }

    void TruckOn()
    {
        gameObject.SetActive(true);
    }

    void TruckOff()
    {
        gameObject.SetActive(false);
    }
}
