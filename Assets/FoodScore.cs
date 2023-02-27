using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScore : MonoBehaviour
{
    public GameObject blur;
    public GameObject foodScore;
    public GameObject market;

    public new GameObject light;

    public GameObject truck1;
    public GameObject truck2;
    public GameObject truck3;
    public GameObject truck4;
    public GameObject truck5;

    private void OnMouseDown()
    {
        light.SetActive(true);
        SoundManager.isClick = true;
        Invoke("MouseEvent", 0.5f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        light.SetActive(true);
        SoundManager.isClick = true;
        Invoke("MouseEvent", 0.5f);
    }

    void MouseEvent()
    {
        light.SetActive(false);

        blur.SetActive(true);
        foodScore.SetActive(true);
        market.SetActive(false);

        truck1.SetActive(false);
        truck2.SetActive(false);
        truck3.SetActive(false);
        truck4.SetActive(false);
        truck5.SetActive(false);
    }
}
