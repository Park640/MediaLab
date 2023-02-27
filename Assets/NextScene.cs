using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public new GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        SoundManager.isClick = true;
        light.SetActive(true);
        Invoke("KitchenLoad", 2f);
    }

    void KitchenLoad()
    {
        SceneManager.LoadScene("Kitchen");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        SoundManager.isClick = true;
        light.SetActive(true);
        Invoke("KitchenLoad", 2f);
    }
}
