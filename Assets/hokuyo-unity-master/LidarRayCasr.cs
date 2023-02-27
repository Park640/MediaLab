using HKY;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LidarRayCasr : MonoBehaviour
{
    public URGSensorObjectDetector URG;
    public Camera cam;


    [SerializeField] float coolTime = 0;
    public float maxTime;
    public bool clickable = true;
    Vector2 offset; // URG의 positionoffset
    int width, height; // URG의 detectWidth, detectHeight
    float camWidth, camHeight; // 카메라의 너비, 높이

    double dx, dy; // 매핑 비율
    RaycastHit2D ray;

    
    private void Update()
    {
        CoolDown();
        if (URG.detectedObjects.Count > 0 && clickable)
        {
            ray = Physics2D.Raycast(MappedPos(URG.detectedObjects[URG.detectedObjects.Count - 1]), transform.position);
            if (ray.collider != null)
            {
                Debug.Log("success");
                ray.collider.gameObject.SendMessage("OnTriggerExit2D", ray.collider);
                clickable = false;
            }
        }
    }
    public void CoolDown()
    {
        if (!clickable && coolTime < maxTime)
        {
            Debug.Log("Cool Now!!");
            coolTime += Time.unscaledDeltaTime;
        }
        else if (coolTime >= maxTime)
        {
            clickable = true;
            coolTime = 0;
        }
    }
    private void Start()
    {
    }
    public void GetRect()
    {
        offset = URG.positionOffset;
        width = URG.detectRectWidth / 2;
        height = URG.detectRectHeight / 2;

        camHeight = cam.orthographicSize;
        camWidth = cam.aspect * camHeight;

        dx = Math.Round(camWidth, 3) / (width / 2);
        dy = camHeight / (height / 2);
    }
    private void Awake()
    {
        GetRect();
        Time.timeScale = 1;
    }
    public Vector2 MappedPos(ProcessedObject obj)
    {
        return new Vector2((obj.position.x - offset.x) * camWidth / width, ((obj.position.y - offset.y) * camHeight / height) + camHeight - camHeight);
    }
}
