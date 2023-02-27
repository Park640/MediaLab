using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartZone : MonoBehaviour
{
    public GameObject colorObj;
    public GameObject foodObj;
    public GameObject signObj;
    public GameObject backgroundObj;

    public static bool isStartScene;

    public void OnMouseDown()
    {
        colorObj.GetComponent<Animator>().enabled = true;
        foodObj.GetComponent<Animator>().enabled = true;
        signObj.GetComponent<Animator>().enabled = true;
        backgroundObj.GetComponent<Animator>().enabled = true;
        gameObject.GetComponent<AudioSource>().Play();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        colorObj.GetComponent<Animator>().enabled = true;
        foodObj.GetComponent<Animator>().enabled = true;
        signObj.GetComponent<Animator>().enabled = true;
        backgroundObj.GetComponent<Animator>().enabled = true;
        gameObject.GetComponent<AudioSource>().Play();
    }
    private void Update()
    {
        if(isStartScene)
        {
            isStartScene= false;
            colorObj.GetComponent<Animator>().enabled = true;
            foodObj.GetComponent<Animator>().enabled = true;
            signObj.GetComponent<Animator>().enabled = true;
            backgroundObj.GetComponent<Animator>().enabled = true;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
