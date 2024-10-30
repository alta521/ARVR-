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
        //마우스 왼쪽 버튼을 누르면 
        if (Input.GetButtonDown("Fire1"))
        {
            //총알 생성
            GameObject Bullet = Instantiate(bullets);
            //총알을 총구에 배치
            Bullet.transform.position = firePosion.position;
            Bullet.transform.forward =firePosion .forward;
            //이펙트 생성

            //Bullet bulletComp = bull
        }
    }
}
