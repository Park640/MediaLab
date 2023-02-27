using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishbox : MonoBehaviour
{
    public new GameObject light;
    private void OnMouseDown()
    {
        light.SetActive(true);
        SoundManager.isCat = true;
        Invoke("LightOn", 2f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        light.SetActive(true);
        SoundManager.isCat = true;
        Invoke("LightOn", 2f);
    }

    void LightOn()
    {
        light.SetActive(false);
    }
}
