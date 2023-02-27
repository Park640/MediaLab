using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadMeat : MonoBehaviour
{
    //public StartZone startzone;

    private void OnMouseDown()
    {
        StartZone.isStartScene = true;
        SceneManager.LoadScene("Mart");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        StartZone.isStartScene = true;
        SceneManager.LoadScene("Mart");
    }
}
