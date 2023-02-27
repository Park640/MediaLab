using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeju : MonoBehaviour
{
    public GameObject toBusan;
    public GameObject toSeoul;
    public GameObject[] destroy;
    public GameObject StrawBerry;
    public GameObject[] myObj;

    private void OnMouseDown()
    {
        for (int i = 0; i < myObj.Length; i++)
        {
            myObj[i].SetActive(true);
        }

        StrawBerry.GetComponent<Animator>().enabled = false;
        for (int i = 0; i < destroy.Length; i++)
        {
            destroy[i].SetActive(false);
        }
        toBusan.SetActive(true);
        toSeoul.SetActive(true);
        toBusan.GetComponent<Animator>().enabled = true;
        toSeoul.GetComponent<Animator>().enabled = true;
        gameObject.GetComponent<AudioSource>().Play();
        gameObject.GetComponentInParent<AudioSource>().Play();

    }

    
}
