using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KitchenToIntro : MonoBehaviour
{
    public float maxTime;
    float time;
    bool coolB = false;
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
                ToIntroScene();
            }
        }
    }
    private void OnMouseDown()
    {
        gameObject.GetComponent<AudioSource>().Play();
        coolB = true;
    }

    void ToIntroScene()
    {
        SceneManager.LoadScene("Intro");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.GetComponent<AudioSource>().Play();
        coolB = true;
    }
}
