using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    bool condition;
    public float speed;

    Rigidbody rigid;
    Vector3 direction;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        if(Input.GetKeyDown(KeyCode.Space) && condition == true) // 이 줄과 같이 n단 점프가 안되도록 해줘야  함
        {
            //AddForce : 오브젝트에 일정한 힘을 가하는 함수
            rigid.AddForce(new Vector3(0, 200, 0)); // 점프 시 200의 힘을 캐릭터에 가하는 것
            condition = false;
        }
    }

    private void FixedUpdate()
    {
        rigid.MovePosition(rigid.position + direction.normalized * speed * Time.deltaTime); // 대각선 이동할 때도 같은 크기로 이동하도록 normalized
    }

    // 1. OnCollisionEnter : 물리적인 충돌을 했을 때 (그 순간에) 호출됨
    private void OnCollisionEnter(Collision collision)
    {
        condition = true;
    }

    // 2. OnCollisionStay : 충돌 중일 때
    private void OnCollisionStay(Collision collision)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    // 3. OnCollisionExit : 충돌에서 벗어났을 때
    private void OnCollisionExit(Collision collision)
    {
        condition = false;
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
