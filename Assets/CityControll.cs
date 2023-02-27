using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityControll : MonoBehaviour
{
    public static bool isStart;

    public void Update()
    {
        if(isStart)
        {
            gameObject.GetComponent<AudioSource>().Play();
            isStart = false;
        }
    }
}
