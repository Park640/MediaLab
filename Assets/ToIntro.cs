using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToIntro : MonoBehaviour
{
    public float maxTime;
    float time;
    bool coolB =false;
    public GameObject black;

    private void Update()
    {
        CoolDown();
    }
    public void CoolDown()
    {
        if (coolB)
        {
            if((time += Time.unscaledDeltaTime) >= maxTime)
            {
                ToIntroScene();
            }
        }
    }
    private void OnMouseDown()
    {
        gameObject.GetComponent<AudioSource>().Play();
        black.GetComponent<Animator>().enabled = true;
        coolB = true;
    }

    void ToIntroScene()
    {
        SceneManager.LoadScene("Intro");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.GetComponent<AudioSource>().Play();
        black.GetComponent<Animator>().enabled = true;
        coolB = true;
    }
}
