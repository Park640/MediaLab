using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foods : MonoBehaviour
{
    public GameObject orange;
    public GameObject orangeFade;
    public GameObject earth;
    public MartController ctrl;
    public GameObject neon;
    private void OnMouseDown()
    {
        neon.SetActive(true);
        Invoke("MouseEvent", 0.5f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        neon.SetActive(true);
        Invoke("MouseEvent", 0.5f);
    }
    void MouseEvent()
    {

        orange.GetComponent<SpriteRenderer>().enabled = true;
        orangeFade.GetComponent<Animator>().enabled = true;
        earth.SetActive(true);
        //earth.GetComponent<Animator>().enabled=true;
        neon.SetActive(false);
        ctrl.Market.SetActive(false);
        ctrl.Plane.SetActive(true);
    }
}
