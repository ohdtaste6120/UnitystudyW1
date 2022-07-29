using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public GameObject target;

    private void Update()
    {
        // 자기 위치의 target의 위치가 3보다 작으면 대상을 바라보도록 설정
        if(Vector3.Distance(transform.position, target.transform.position) <= 3)
        {
            transform.LookAt(target.transform);
        }
        // 그렇지 않다면 회전 값은 15, 90, 0인 초기값으로 다시 돌아감
        else
        {
            transform.rotation = Quaternion.Euler(15, 90, 0);
        }
        
    }
}
