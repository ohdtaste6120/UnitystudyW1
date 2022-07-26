using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Sensor : MonoBehaviour
{
    private VideoPlayer video;

    void Start()
    {
        video = GetComponent<VideoPlayer>();
    }

    private void OnTriggerEnter(Collider other) // 물리적인 연산을 수행하지 않고 충돌 했을 때 감지하는 함수
    {
        video.Play();
    }

    private void OnTriggerStay(Collider other) // 물리적인 연산을 수행하지 않고  충돌 중일 때 감지하는 함수
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    private void OnTriggerExit(Collider other) // 물리적인 연산을 수행하지 않고 충돌을 벗어났을 때 감지하는 함수
    {
        video.Stop();
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

}
