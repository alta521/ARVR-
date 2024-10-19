using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        //�Է°��������� ���
        Move();
    }
    void Move()
    {
        //������� �Է¿� ���� ���� ����
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        //Vector3 dir = Vector3.right*H + Vector3.forward*V;
        //�������� �ؾ����� �����Ұ�.
        //�յ� ���� ����
        Vector3 dir = new Vector3(H, 0, V);
        //ī�޶� �չ������� ���� ������ �չ����� �缳��.(������ ��� �ٸ��� ���� ���� �̰� �չ����̴� �缳���ϴ°���.)
        dir = cam.transform.TransformDirection(dir);
        dir.y = 0;
        dir.Normalize();
        //������Ʈ�� ������ �̵��� ���Ͽ�, ��� ������ ������ ���̰� 1�̾�� ���⿡ ���� �̵��ӵ��� �������⶧��<<��Ȯ�ϰ� ����� �ȳ��µ� ���ش� ������. �� �¿� �յ��� �̵��� +1�� �̵��ε� �밢���� ��Ʈ2�� �̵��̹Ƿ� 1.41~�� �̵��ӵ��� ����.
        transform.position += dir*speed*Time.deltaTime;
        //�¿�յ� �Է°��� ���� ����Ʈ���� Ȱ���Ͽ� �ִϸ��̼� ����

    }
}
