using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    //���콺 ���� ��ư�� ������ 
    //�Ѿ� ����
    //�Ѿ��� �ѱ��� ��ġ
    public GameObject bullets;
    public Transform firePosion;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire!"))
        {
            GameObject Bullet = Instantiate(bullets);
            Bullet.transform.position = firePosion.position;
            Bullet.transform.forward =firePosion .forward;
            //Bullet bulletComp = bull
        }
    }
}
