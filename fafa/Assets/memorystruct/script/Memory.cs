using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    protected int health; // public : �ܺο����� �����Ͽ� ��� ����
    protected int attack; // private : �� �ڽŸ� �����Ͽ� ��� ����
    public string name; // protected : �� �ڽŰ� ����ϰ� �ִ� Ŭ���������� �����Ͽ� ��� ����
    

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
    // �ڵ� ���� : ���α׷��� ����Ǵ� ���� 
    // ������ ���� : ���� ������ ���� ������ ����Ǵ� ����
    // �� ���� : �������� ������ �޸𸮸� �����ϴ� ����
    // ���� ���� : ���� ������ �Լ��� �Ű������� ����Ǵ� ����
    // ���� Last In First Out , �� First In First Out
    */

    public int value = 100;
    void Start()
    {
        health = 100;
        attack = 100;
        Information();
        Move();

        int value = 250; // value��� �޸� ���� ������. <- '��������'��

        // ���������� �Լ� �ȿ��� �����ǰ� �Լ��� ����� �Ҹ��ϴ� �Լ���

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
        transform.position += new Vector3(1, 1, 0) * Time.deltaTime; // += : ���� �����ؼ� ������ 
        
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

    //void : �ڷ����� �������� ������ �ǹ�
}
