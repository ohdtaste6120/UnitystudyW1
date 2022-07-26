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

    private void OnTriggerEnter(Collider other) // �������� ������ �������� �ʰ� �浹 ���� �� �����ϴ� �Լ�
    {
        video.Play();
    }

    private void OnTriggerStay(Collider other) // �������� ������ �������� �ʰ�  �浹 ���� �� �����ϴ� �Լ�
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    private void OnTriggerExit(Collider other) // �������� ������ �������� �ʰ� �浹�� ����� �� �����ϴ� �Լ�
    {
        video.Stop();
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

}
