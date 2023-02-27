using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    public Animator[] letters;
    public GameObject fadeOut;
    public SpriteRenderer sr;
    public Animator[] anims;

    string animBool = "shiverOn";

    private void Update()
    {
        if(sr.color.a >= 1)
        {
            SceneManager.LoadScene("Mart");
        }
    }
    public void ShiverOn()
    {
        foreach(Animator a in letters)
        {
            a.SetBool(animBool, true);
        }
    }
    public void ShiverOff()
    {
        foreach (Animator a in letters)
        {
            a.SetBool(animBool, false);
        }
    }
    public void FadeOut()
    {
        fadeOut.SetActive(true);
    }
    public void ColorOn()
    {
        anims[0].enabled = true;
        anims[1].enabled = true;    
    }
    public void MarkOn()
    {
        anims[2].enabled = true;
    }


}
