using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiwi : MonoBehaviour
{
    public GameObject kiwiFruit;
    public GameObject kiwiNeon;
    private void OnMouseDown()
    {
        kiwiFruit.SetActive(false);
        kiwiFruit.SetActive(true);
        kiwiFruit.GetComponent<Animator>().enabled = true;
        kiwiNeon.SetActive(true);
        Invoke("neonDestory", 1f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        kiwiFruit.SetActive(false);
        kiwiFruit.SetActive(true);
        kiwiFruit.GetComponent<Animator>().enabled = true;
        kiwiNeon.SetActive(true);
        Invoke("neonDestory", 1f);
    }

    void neonDestory()
    {
        kiwiNeon.SetActive(false);
    }
}
