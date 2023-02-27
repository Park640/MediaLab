using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMap : MonoBehaviour
{
    public GameObject worldMap;
    public GameObject worldMapBlur;
    public GameObject market;
    public new GameObject light;
    //public GameObject[] ship;

    private void OnMouseDown()
    {
        light.SetActive(true);
        /*for(int i = 0; i < ship.Length; i++)
        {
            ship[i].SetActive(false);
        }*/
        Invoke("MouseEvent", 0.5f);
        SoundManager.isClick = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        light.SetActive(true);
        /*for(int i = 0; i < ship.Length; i++)
        {
            ship[i].SetActive(false);
        }*/
        Invoke("MouseEvent", 0.5f);
        SoundManager.isClick = true;
    }
    void MouseEvent()
    {
        light.SetActive(false);
        market.SetActive(false);
        worldMapBlur.SetActive(true);
        worldMap.SetActive(true);
    }
}
