using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class coke : MonoBehaviour
{
    public new GameObject light;
    private void OnMouseDown()
    {
        light.SetActive(true);
        SoundManager.isCoke = true;
        Invoke("LightOn", 2f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        light.SetActive(true);
        SoundManager.isCoke = true;
        Invoke("LightOn", 2f);
    }

    void LightOn()
    {
        light.SetActive(false);
    }
}
