using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    /*
    // ����, �Ǽ�, ���ڿ� �� ��� ���� �� ������ �տ� �ڷ����� ����ؾ� ��
    //���α׷��� ����Ǵ� ������ ������ �Ʒ���...

    // �Ʒ��� hp�� ������ �̸���
    // 4byte ũ���� �޸� ���� ������
    // ����� : int�� string �� �������ִ� �� 
    // ���� �̸��� ��ҹ��� ���� . ����� ��� �Ұ� . ���ڷ� ���� �Ұ� . ���� ���� �Ұ� . Ư�����ڴ� ����� Ȥ�� �޷��� ��� ����
    */
   
    // hp��� �޸� ������ ���� �����ؾ� ��(�ƴ� ��� �⺻������ 0�� ��)
    public int hp = 100;

    // ���ڿ��� ������
    public string nAme = "Choi Si Nae";

    public char bloodType = 'O';

    public float height = 175.6f;

    // Start is called before the first frame update : ���� ���� �� �� �� ���� ȣ��Ǵ� �Լ�
    void Start()
    {
        hp = 300;
        //���ڿ��̾ �ٸ� ����ó�� ���⼭ �ٸ� ������ ���� ����

        // ���� ������Ʈ�� �Ӽ��� �ʱ�ȭ�� �� ���
        print(hp);
        print(name);
        print(height);
        print(bloodType);
    }

    // Update is called once per frame : ������ ����Ǿ��� �� �� �����Ӹ��� ȣ��Ǵ� �Լ�
    void Update()
    {
        // ���� ������Ʈ�� �Է��̳� ��ġ �̵��� �� �� ���
    }
}
