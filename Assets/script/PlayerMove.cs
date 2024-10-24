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
        //�Է°��������� ���
        Move();
        ARani.SetFloat("HM", H);
        ARani.SetFloat("VM", V);
    }
    void Move()
    {
        //������� �Է¿� ���� ���� ����
        H = Input.GetAxis("Horizontal");
        V = Input.GetAxis("Vertical");
        //Vector3 dir = Vector3.right*H + Vector3.forward*V;
        //�������� �ؾ����� �����Ұ�.
        //�յ� ���� ����
        Vector3 dirH = transform.right * H;
        Vector3 dirV = transform.forward * V;
        Vector3 dir = dirH + dirV;
        //ī�޶� �չ������� ���� ������ �չ����� �缳��.(������ ��� �ٸ��� ���� ���� �̰� �չ����̴� �缳���ϴ°���.)
        dir = cam.transform.TransformDirection(dir);
        dir.y = 0;
        dir.Normalize();
        //������Ʈ�� ������ �̵��� ���Ͽ�, ��� ������ ������ ���̰� 1�̾�� ���⿡ ���� �̵��ӵ��� �������⶧��<<��Ȯ�ϰ� ����� �ȳ��µ� ���ش� ������. �� �¿� �յ��� �̵��� +1�� �̵��ε� �밢���� ��Ʈ2�� �̵��̹Ƿ� 1.41~�� �̵��ӵ��� ����.
        transform.position += dir*speed*Time.deltaTime;
        //�¿�յ� �Է°��� ���� ����Ʈ���� Ȱ���Ͽ� �ִϸ��̼� ����

        //camrot�� ���߾� ȸ���ؾ���..
    }
}
