using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Korea : MonoBehaviour
{
    public bool isFruit;
    public GameObject[] destroy;
    public GameObject[] myObj;
    public GameObject neon;
    public GameObject soundManage;

    private void OnMouseDown()
    {
        var childs = soundManage.GetComponentsInChildren<AudioSource>();
        gameObject.GetComponentInParent<Animator>().SetBool("isKorea", true);
        if (isFruit)
        {
            for (int i = 0; i < myObj.Length; i++)
            {
                myObj[i].SetActive(false);
                myObj[i].SetActive(true);
                myObj[i].GetComponent<Animator>().enabled = true;
            }
            //gameObject.GetComponent<Animator>().enabled = true;
            for (int i = 0; i < destroy.Length; i++)
            {
                destroy[i].SetActive(false);

            }

        }
        // 수정
        foreach (var col in childs)
        {
            col.Stop();
        }

        neon.SetActive(true);
        Invoke("neonDestory", 1f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        var childs = soundManage.GetComponentsInChildren<AudioSource>();
        gameObject.GetComponentInParent<Animator>().SetBool("isKorea", true);
        if (isFruit)
        {
            for (int i = 0; i < myObj.Length; i++)
            {
                myObj[i].SetActive(false);
                myObj[i].SetActive(true);
                myObj[i].GetComponent<Animator>().enabled = true;
            }
            //gameObject.GetComponent<Animator>().enabled = true;
            for (int i = 0; i < destroy.Length; i++)
            {
                destroy[i].SetActive(false);

            }

        }
        // 수정
        foreach (var col in childs)
        {
            col.Stop();
        }

        neon.SetActive(true);
        Invoke("neonDestory", 1f);
    }

    void neonDestory()
    {
        neon.SetActive(false);
    }

    void Fruit()
    {
        isFruit = true;
    }
}
