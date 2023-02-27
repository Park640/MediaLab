using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBeef : MonoBehaviour
{
    public GameObject beefTruck;
    public AudioSource sounds;

    private void OnMouseDown()
    {
        beefTruck.SetActive(false);
        beefTruck.SetActive(true);
        sounds.Play();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        beefTruck.SetActive(false);
        beefTruck.SetActive(true);
        sounds.Play();
    }

}
