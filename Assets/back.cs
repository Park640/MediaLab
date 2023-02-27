using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class back : MonoBehaviour
{
    public GameObject Market;
    public GameObject Blur;
    public GameObject Map;

    public GameObject soundManage;

    public GameObject[] ship;

    private void OnMouseDown()
    {
        SoundManager.isClick = true;
        Market.SetActive(true);
        Blur.SetActive(false);
        Map.SetActive(false);
        var child = soundManage.GetComponentsInChildren<AudioSource>();
        foreach(var audio in child)
        {
            audio.Stop();
        }
        for(int i = 0; i < ship.Length; i++)
        {
            ship[i].GetComponent<Animator>().enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        SoundManager.isClick = true;
        Market.SetActive(true);
        Blur.SetActive(false);
        Map.SetActive(false);
        var child = soundManage.GetComponentsInChildren<AudioSource>();
        foreach (var audio in child)
        {
            audio.Stop();
        }
        for (int i = 0; i < ship.Length; i++)
        {
            ship[i].GetComponent<Animator>().enabled = false;
        }
    }
}
