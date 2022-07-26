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

        if(Input.GetKeyDown(KeyCode.Space) && condition == true) // �� �ٰ� ���� n�� ������ �ȵǵ��� �����  ��
        {
            //AddForce : ������Ʈ�� ������ ���� ���ϴ� �Լ�
            rigid.AddForce(new Vector3(0, 200, 0)); // ���� �� 200�� ���� ĳ���Ϳ� ���ϴ� ��
            condition = false;
        }
    }

    private void FixedUpdate()
    {
        rigid.MovePosition(rigid.position + direction.normalized * speed * Time.deltaTime); // �밢�� �̵��� ���� ���� ũ��� �̵��ϵ��� normalized
    }

    // 1. OnCollisionEnter : �������� �浹�� ���� �� (�� ������) ȣ���
    private void OnCollisionEnter(Collision collision)
    {
        condition = true;
    }

    // 2. OnCollisionStay : �浹 ���� ��
    private void OnCollisionStay(Collision collision)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    // 3. OnCollisionExit : �浹���� ����� ��
    private void OnCollisionExit(Collision collision)
    {
        condition = false;
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
