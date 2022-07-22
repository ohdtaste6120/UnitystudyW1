using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    protected int health; // public : 외부에서도 접근하여 사용 가능
    protected int attack; // private : 나 자신만 접근하여 사용 가능
    public string name; // protected : 나 자신과 상속하고 있는 클래스까지만 접근하여 사용 가능
    

    public void Information()
    {
        print(health);
        print(attack);
        print(name);
    }
}



public class Memory : Monster
{
    /*
    // 코드 영역 : 프로그램이 실행되는 영역 
    // 데이터 영역 : 전역 변수와 정적 변수가 저장되는 영역
    // 힙 영역 : 동적으로 생성한 메모리를 관리하는 영역
    // 스택 영역 : 지역 변수와 함수의 매개변수가 저장되는 영역
    // 스택 Last In First Out , 힙 First In First Out
    */

    public int value = 100;
    void Start()
    {
        health = 100;
        attack = 100;
        Information();
        Move();

        int value = 250; // value라는 메모리 공간 생성됨. <- '지역변수'임

        // 지역변수는 함수 안에서 생성되고 함수를 벗어나면 소멸하는 함수임

        int area = 500;
    }

    private void Update()
    {
        Move();
        // Calculator(10, 45);
        print(Add(10, 10));
    }

    private void Move()
    {
        transform.position += new Vector3(1, 1, 0) * Time.deltaTime; // += : 값이 누적해서 더해짐 
        
    }

    private void Calculator(int x, int y)
    {
        int temp = y + x;
        print(temp);
    }

    private int Add(int x, int y)
    {
        return x + y;
    }

    //void : 자료형이 존재하지 않음을 의미
}
