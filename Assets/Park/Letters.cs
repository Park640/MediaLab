using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letters : MonoBehaviour
{
    public IntroScene intro;
    public Animator animator;
    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.enabled= true;
    }
    private void OnMouseDown()
    {
        animator.enabled = true;

    }
    public void ShiverOn()
    {
        intro.ShiverOn();
    }
}
