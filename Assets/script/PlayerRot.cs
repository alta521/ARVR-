using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRot : MonoBehaviour
{
    //설정한 함수
    float rx;
    float ry;
    public float rotSpeed = 200;

    void Start()
    {
        
    }

    void Update()
    {
        //입력값을 받음
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        rx += my * rotSpeed * Time.deltaTime;
        ry += mx * rotSpeed * Time.deltaTime;
        //회전 제한
        rx = Mathf.Clamp(rx, -75, 75);
        //ry = Mathf.Clamp(ry, -75,75);
        //카메라 회전
        transform.eulerAngles = new Vector3(-rx, ry, 0);

    }
}
