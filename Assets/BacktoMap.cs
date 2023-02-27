using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacktoMap : MonoBehaviour
{
    public GameObject[] destroy;
    public GameObject korea;
    public GameObject toSeoul;
    public GameObject toBusan;
    public GameObject[] ship;

    public GameObject soundManage;
    private void OnMouseDown()
    {
        gameObject.GetComponent<AudioSource>().Play();
        for(int i = 0; i < destroy.Length; i++)
        {
            destroy[i].SetActive(false);
            
        }
        var ani = korea.GetComponentsInChildren<Animator>();
        foreach(var child in ani)
        {
            child.enabled = false;
        }
        gameObject.GetComponentInParent<Animator>().SetBool("isKorea", false);
        toBusan.SetActive(false);
        toSeoul.SetActive(false);

        var sounds = soundManage.GetComponentsInChildren<AudioSource>();

        foreach(var ss in sounds)
        {
            ss.Stop();
        }
        for(int i = 0; i < ship.Length; i++)
        {
            ship[i].GetComponent<Animator>().enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.GetComponent<AudioSource>().Play();
        for (int i = 0; i < destroy.Length; i++)
        {
            destroy[i].SetActive(false);

        }
        var ani = korea.GetComponentsInChildren<Animator>();
        foreach (var child in ani)
        {
            child.enabled = false;
        }
        gameObject.GetComponentInParent<Animator>().SetBool("isKorea", false);
        toBusan.SetActive(false);
        toSeoul.SetActive(false);

        var sounds = soundManage.GetComponentsInChildren<AudioSource>();

        foreach (var ss in sounds)
        {
            ss.Stop();
        }
        for (int i = 0; i < ship.Length; i++)
        {
            ship[i].GetComponent<Animator>().enabled = false;
        }
    }
}
