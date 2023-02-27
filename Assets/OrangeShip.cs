using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeShip : MonoBehaviour
{
    public GameObject orangeShip;
    public GameObject orangeNeon;
    private void OnMouseDown()
    {
        orangeShip.SetActive(false);
        orangeShip.SetActive(true);
        orangeShip.GetComponent<Animator>().enabled = true;
        orangeNeon.SetActive(true);
        Invoke("neonDestory", 1f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        orangeShip.SetActive(false);
        orangeShip.SetActive(true);
        orangeShip.GetComponent<Animator>().enabled = true;
        orangeNeon.SetActive(true);
        Invoke("neonDestory", 1f);
    }

    void neonDestory()
    {
        orangeNeon.SetActive(false);
    }
}
