using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void Move()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        //Vector3 dir = Vector3.right*H + Vector3.forward*V;
        //선형보간 잊었으니 공부할것.
        Vector3 dir = new Vector3(H, 0, V);
        dir.Normalize();
        //오브젝트의 균일한 이동을 위하여, 모든 방향의 벡터의 길이가 1이어야 방향에 따른 이동속도가 같아지기때문<<정확하게 기억이 안나는데 이해는 가능함. 아 좌우 앞뒤의 이동은 +1의 이동인데 대각선은 루트2의 이동이므로 1.41~의 이동속도를 지님.
        transform.position += dir*speed*Time.deltaTime;
        //좌우앞뒤 입력값을 통해 블렌드트리를 활용하여 애니메이션 설정

    }
}
