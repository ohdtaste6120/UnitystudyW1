using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public GameObject target;

    private void Update()
    {
        // �ڱ� ��ġ�� target�� ��ġ�� 3���� ������ ����� �ٶ󺸵��� ����
        if(Vector3.Distance(transform.position, target.transform.position) <= 3)
        {
            transform.LookAt(target.transform);
        }
        // �׷��� �ʴٸ� ȸ�� ���� 15, 90, 0�� �ʱⰪ���� �ٽ� ���ư�
        else
        {
            transform.rotation = Quaternion.Euler(15, 90, 0);
        }
        
    }
}
