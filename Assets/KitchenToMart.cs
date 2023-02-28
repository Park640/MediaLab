using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KitchenToMart : MonoBehaviour
{
    public float maxTime;
    float time;
    bool coolB = false;
    public GameObject black;

    private void Update()
    {
        CoolDown();
    }
    public void CoolDown()
    {
        if (coolB)
        {
            if ((time += Time.unscaledDeltaTime) >= maxTime)
            {
                ToMartScene();
                
            }
        }
    }
    private void OnMouseDown()
    {
        //gameObject.GetComponent<AudioSource>().Play();
        black.GetComponent<Animator>().enabled = true;
        coolB = true;
    }

    void ToMartScene()
    {
        StartZone.isStartScene = true;
        SceneManager.LoadScene("Mart");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //gameObject.GetComponent<AudioSource>().Play();
        black.GetComponent<Animator>().enabled = true;
        coolB = true;
    }
}
