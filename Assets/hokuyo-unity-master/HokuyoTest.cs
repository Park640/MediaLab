using HKY;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class HokuyoTest : MonoBehaviour
{
    [DllImport("user32.dll")]
    static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

    public URGSensorObjectDetector URG;
    public Camera cam;
    public GameObject clickObj;
    public Transform returnPos;

    [SerializeField] float coolTime = 0;
    Vector2 offset; // URG의 positionoffset
    int width, height; // URG의 detectWidth, detectHeight
    float camWidth, camHeight; // 카메라의 너비, 높이

    double dx, dy; // 매핑 비율

    public void GetRect()
    {
        offset = URG.positionOffset;
        width = URG.detectRectWidth/2;
        height = URG.detectRectHeight/2;

        camHeight = cam.orthographicSize;
        camWidth = cam.aspect * camHeight;

        dx = Math.Round(camWidth, 3) / (width/2);
        dy = camHeight / (height/2);
    }

    public Vector2 MappedPos(ProcessedObject obj)
    {
        return new Vector2(-(obj.position.x - offset.x) * camWidth / width, camHeight-((obj.position.y - offset.y) * camHeight / height));

    }
    private void Awake()
    {
        GetRect();
    }
    private void Update()
    {
        if (URG.detectedObjects.Count > 0)
        {
            coolTime = 0;
            clickObj.transform.position = MappedPos(URG.detectedObjects[URG.detectedObjects.Count - 1]);
        }
        else
        {
            if ((coolTime += Time.deltaTime) >= 0.3) StartCoroutine(ClickDestroy());
        }
    }
    

    IEnumerator ClickDestroy()
    {
        coolTime= 0;
        yield return new WaitForSeconds(0);
        clickObj.transform.position = returnPos.position;
    }
}
