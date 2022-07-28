using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Various : MonoBehaviour
{
    private float timer;
    public Image stateImage;
    public Sprite[] stateIcon;

    void Start()
    {
        // 아래 함수는 특정한 함수를 1초 뒤에 3초마다 반복하도록 설정함
        InvokeRepeating("Position", 1, 3);

        StartCoroutine(Paint());
    }

    void Update()
    { // 쿨타임 작업
        timer += Time.deltaTime;

        if(timer >= 5.0f)
        {
            Invoke("ChangeSprite", 0); // 함수이름 정확하게 입력, 특정 시간(초) 입력해줌 : 이 함수는 지정된 시간 뒤에 호출됨

            timer = 0.0f; 
        }
    }

    public IEnumerator Paint() // Main/Sub/Co Routine : 코루틴은 메인에 제어권을 돌려줌 , 코루틴 사용하면 CPU 유휴 시간 늘어나 최적화된 상태를 만듦
    {
        while (true)
        {
            yield return new WaitForSeconds(3.0f);

            gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));

        }
    }

    public void ChangeSprite()
    {
        switch (Random.Range(0, 3))
        {
            case 0: stateImage.sprite = stateIcon[0];
                break;
            case 1: stateImage.sprite = stateIcon[1];
                break;
            case 2: stateImage.sprite = stateIcon[2];
                break;
        }
    } 
    
    public void Position()
    {
        transform.position = new Vector3(Random.Range(-2.5f, 2.5f), 0, Random.Range(-2.5f, 2.5f));
    }
}
