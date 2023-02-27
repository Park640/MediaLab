using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFood : MonoBehaviour
{
    public Scenario scenario;
    public Bgm bgm;

    public GameObject newneon;
    private void OnMouseDown()
    {
        newneon.SetActive(true);
        Invoke("MouseEvent", 0.5f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        newneon.SetActive(true);
        Invoke("MouseEvent", 0.5f);
    }

    void MouseEvent()
    {
        newneon.SetActive(false);
        scenario.ChangeScene();
        bgm.Select1();
    }
}
