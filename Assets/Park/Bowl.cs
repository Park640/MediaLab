using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bowl : MonoBehaviour
{
    public IntroScene intro;
    public Animator stickAnim;
    public AudioSource[] bgm;

    BoxCollider2D coll;
    int sceneNo = 0;
    bool collB = true;
    private void Awake()
    {
        coll = GetComponent<BoxCollider2D>();
    }

    void ClickSoundOn()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (sceneNo == 0)
        {
            //BgmOn(0);
            intro.ColorOn();
            sceneNo++;
            //BgmOn(1);
            //stickAnim.SetBool("stickOn", true);
        }
        else if (sceneNo == 1)
        {

        }
    }
    public void BgmOn(int i)
    {
        bgm[i].Play();
    }
    public void CollToggle()
    {
        collB = !collB;
        coll.enabled = collB;
    }
    public void StickOn()
    {
        stickAnim.SetBool("stickOn", true);
        BgmOn(1);

    }
    private void OnMouseDown()
    {
        if (sceneNo == 0)
        {
            intro.ColorOn();
            sceneNo++;
        }
        else if (sceneNo == 1)
        {


        }
    }
}
