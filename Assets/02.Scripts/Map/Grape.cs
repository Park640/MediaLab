using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grape : MonoBehaviour
{
    public GameObject grapeFruit;
    public GameObject grapeNeon;
    private void OnMouseDown()
    {
        grapeFruit.SetActive(false);
        grapeFruit.SetActive(true);
        grapeFruit.GetComponent<Animator>().enabled = true;
        grapeNeon.SetActive(true);
        Invoke("neonDestory", 1f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        grapeFruit.SetActive(false);
        grapeFruit.SetActive(true);
        grapeFruit.GetComponent<Animator>().enabled = true;
        grapeNeon.SetActive(true);
        Invoke("neonDestory", 1f);
    }

    void neonDestory()
    {
        grapeNeon.SetActive(false);
    }
}
