using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public GameObject bullets;
    public Transform firePosion;
    //public GameObject bulletsImpact;
    void Start()
    {
        
    }

    void Update()
    {
        //���콺 ���� ��ư�� ������ 
        if (Input.GetButtonDown("Fire1"))
        {
            //�Ѿ� ����
            GameObject Bullet = Instantiate(bullets);
            //�Ѿ��� �ѱ��� ��ġ
            Bullet.transform.position = firePosion.position;
            Bullet.transform.forward =firePosion .forward;
            //����Ʈ ����

            //Bullet bulletComp = bull
        }
    }
}
