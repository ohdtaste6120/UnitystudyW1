using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    /*
    // 정수, 실수, 문자열 중 어느 것을 쓸 것인지 앞에 자료형을 명시해야 함
    //프로그램이 실행되는 순서는 위에서 아래로...

    // 아래의 hp는 변수의 이름임
    // 4byte 크기의 메모리 공간 생성됨
    // 예약어 : int나 string 등 정해져있는 거 
    // 변수 이름은 대소문자 구분 . 예약어 사용 불가 . 숫자로 시작 불가 . 공백 포함 불가 . 특수문자는 언더바 혹은 달러만 사용 가능
    */
   
    // hp라는 메모리 공간에 값을 저장해야 함(아닌 경우 기본값으로 0이 들어감)
    public int hp = 100;

    // 문자열도 변수임
    public string nAme = "Choi Si Nae";

    public char bloodType = 'O';

    public float height = 175.6f;

    // Start is called before the first frame update : 게임 실행 시 단 한 번만 호출되는 함수
    void Start()
    {
        hp = 300;
        //문자열이어도 다른 변수처럼 여기서 다른 값으로 변경 가능

        // 게임 오브젝트의 속성을 초기화할 때 사용
        print(hp);
        print(name);
        print(height);
        print(bloodType);
    }

    // Update is called once per frame : 게임이 실행되었을 때 매 프레임마다 호출되는 함수
    void Update()
    {
        // 게임 오브젝트의 입력이나 위치 이동을 할 때 사용
    }
}
