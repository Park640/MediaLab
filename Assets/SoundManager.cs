using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static bool isSound;
    public static bool isPlaneSound;
    public static bool isPlaneStop;
    public static bool isTree;
    public static bool isFac;
    public static bool isBox;
    public static bool isTruck;
    public static bool isTruckStop;
    public static bool isSea;
    public static bool isSeagul;
    public static bool isSeagulStop;
    public static bool is70ShipSound;
    public static bool isEngineSound;
    public static bool isClick;
    public static bool isCoke;
    public static bool isCat;
    public static bool isGoat;
    public GameObject isOrange;
    public AudioSource orange;
    public AudioSource plane;
    public AudioSource tree;
    public AudioSource factory;
    public AudioSource box;
    public AudioSource truck;
    public AudioSource sea;
    public GameObject seagul;
    public AudioSource shipSound;
    public AudioSource engine;
    public AudioSource clickSound;
    public AudioSource cokeSound;
    public AudioSource goatSound;
    public AudioSource catSound;


    void Start()
    {
        
    }

    public static void SoundOn()
    {
        SoundManager.isSound = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(isOrange.GetComponent<Animator>().enabled == true)
        {
            //audiosource.PlayOneShot(orange);
        }
        if (isSound)
        {
            isSound = false;
            orange.Play();
            Debug.Log("Sound");
        }
        if (isPlaneSound)
        {
            isPlaneSound = false;
            plane.Play();
        }
        if (isPlaneStop)
        {
            plane.Stop();
        }
        if (isTree)
        {
            isTree = false;
            tree.Play();
        }
        if (isFac)
        {
            isFac = false;
            factory.Play();
        }
        if (isBox)
        {
            isBox= false;
            box.Play();
        }
        if (isTruck)
        {
            isTruck = false;
            truck.Play();
        }
        if (isTruckStop)
        {
            truck.Stop();
        }
        if (isSea)
        {
            isSea = false;
            sea.Play();
        }
        if (isSeagul)
        {
            isSeagul = false;
            seagul.GetComponent<AudioSource>().enabled = true;
            seagul.GetComponent<AudioSource>().Play();
        }
        if (isSeagulStop)
        {
            seagul.GetComponent<AudioSource>().enabled = false;
        }
        if(is70ShipSound)
        {
            is70ShipSound = false;
            shipSound.Play();
        }
        if(isEngineSound)
        {
            isEngineSound = false;
            engine.Play();
        }
        if (isClick)
        {
            isClick = false;
            clickSound.Play();
        }
        if (isCoke)
        {
            isCoke= false;
            cokeSound.Play();
        }
        if(isCat)
        {
            isCat = false;
            catSound.Play();
        }
        if(isGoat)
        {
            isGoat = false;
            goatSound.Play();
        }
    }
}
