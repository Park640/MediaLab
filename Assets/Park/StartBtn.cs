using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBtn : MonoBehaviour
{
    public Scenario scenario;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scenario.StartColor();
    }
    private void OnMouseDown()
    {
        scenario.StartColor();
    }
}
