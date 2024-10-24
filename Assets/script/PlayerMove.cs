using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    Camera cam;
    CharacterController characterController;
    public Animator ARani;
    public float H;
    public float V;


    void Start()
    {
        cam = Camera.main;
        ARani = GetComponent<Animator>();
    }

    void Update()
    {
        //입력값이있으면 출력
        Move();
        ARani.SetFloat("HM", H);
        ARani.SetFloat("VM", V);
    }
    void Move()
    {
        //사용자의 입력에 따라 값을 받음
        H = Input.GetAxis("Horizontal");
        V = Input.GetAxis("Vertical");
        //Vector3 dir = Vector3.right*H + Vector3.forward*V;
        //선형보간 잊었으니 공부할것.
        //앞뒤 방향 설정
        Vector3 dirH = transform.right * H;
        Vector3 dirV = transform.forward * V;
        Vector3 dir = dirH + dirV;
        //카메라 앞방향으로 현재 방향의 앞방향을 재설정.(세계의 축과 다르게 나의 축을 이게 앞방향이다 재설정하는거임.)
        dir = cam.transform.TransformDirection(dir);
        dir.y = 0;
        dir.Normalize();
        //오브젝트의 균일한 이동을 위하여, 모든 방향의 벡터의 길이가 1이어야 방향에 따른 이동속도가 같아지기때문<<정확하게 기억이 안나는데 이해는 가능함. 아 좌우 앞뒤의 이동은 +1의 이동인데 대각선은 루트2의 이동이므로 1.41~의 이동속도를 지님.
        transform.position += dir*speed*Time.deltaTime;
        //좌우앞뒤 입력값을 통해 블렌드트리를 활용하여 애니메이션 설정

        //camrot에 맞추어 회전해야함..
    }
}
