using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheat : MonoBehaviour
{
    public GameObject wheat;
    public GameObject wheatNeon;

    private void OnMouseDown()
    {
        wheat.SetActive(false);
        wheat.SetActive(true);
        wheat.GetComponent<Animator>().enabled = true;
        wheatNeon.SetActive(true);
        Invoke("neonDestory", 1f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        wheat.SetActive(false);
        wheat.SetActive(true);
        wheat.GetComponent<Animator>().enabled = true;
        wheatNeon.SetActive(true);
        Invoke("neonDestory", 1f);
    }
    void neonDestory()
    {
        wheatNeon.SetActive(false);
    }
}