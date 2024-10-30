using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRot : MonoBehaviour
{
    //������ �Լ�
    float rx;
    float ry;
    public float rotSpeed = 200;

    void Start()
    {
        
    }

    void Update()
    {
        //�Է°��� ����
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        rx += my * rotSpeed * Time.deltaTime;
        ry += mx * rotSpeed * Time.deltaTime;
        //ȸ�� ����
        rx = Mathf.Clamp(rx, -75, 75);
        //ry = Mathf.Clamp(ry, -75,75);
        //ī�޶� ȸ��
        transform.eulerAngles = new Vector3(-rx, ry, 0);

    }
}
