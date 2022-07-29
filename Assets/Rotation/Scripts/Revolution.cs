using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public GameObject origin; // 기준 축이 되는 게임 오브젝트
    public float speed = 1.0f; // 회전 속도

    void Update()
    {
        transform.RotateAround(origin.transform.position, // 회전을 하기 위한 기준이 되는 게임 오브젝트
            Vector3.down, // 회전할 축
            speed * Time.deltaTime); // 회전 속도
    }
}
