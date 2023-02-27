using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chopsticks : MonoBehaviour
{
    public IntroScene intro;
    public void MarkOn()
    {
        intro.MarkOn();
    }
    public void ShiverOff()
    {
        intro.ShiverOff();
    }
    public void FadeOut()
    {
        intro.FadeOut();
    }
}
