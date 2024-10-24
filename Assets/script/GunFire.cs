using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    //마우스 왼쪽 버튼을 누르면 
    //총알 생성
    //총알을 총구에 배치
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
