using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reloadScene : MonoBehaviour
{
    public GameObject plane;
    public GameObject firstScene;
    public GameObject earth;

    public GameObject soundManage;

    private void OnMouseDown()
    {
        SoundManager.isClick = true;
        plane.SetActive(false);
        firstScene.SetActive(true);
        var child = soundManage.GetComponentsInChildren<AudioSource>();
        foreach(var sound in child)
        {
            sound.Stop();
        }
        earth.SetActive(false);
        earth.GetComponent<Animator>().enabled = false;
        //SceneManager.LoadScene("Mart");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        SoundManager.isClick = true;
        plane.SetActive(false);
        firstScene.SetActive(true);
        var child = soundManage.GetComponentsInChildren<AudioSource>();
        foreach (var sound in child)
        {
            sound.Stop();
        }
        earth.SetActive(false);
        earth.GetComponent<Animator>().enabled = false;
    }
}
