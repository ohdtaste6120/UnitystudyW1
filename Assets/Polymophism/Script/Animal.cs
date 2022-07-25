using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public int age;
    public string name;


    void Start()
    {
        Animal dog = new Dog();
        Animal cat = new Cat();
        Animal duck = new Duck();

        dog.Sound();
        cat.Sound();
        duck.Sound();
    }

    public virtual void Sound()
    {
        Debug.Log("�����Ҹ�");
    }

    public void Information()
    {
        Debug.Log("Age : " + age);
        Debug.Log("Name : " + name);
    }
}
public class Dog : Animal
{
   public override void Sound()
    {
        Debug.Log("�۸� !");
    }
    public Dog() // private void Start() �� ����
    {
        age = 10;
        name = "Dog";
        Information();        
    }
}

public class Cat : Animal
{
    public override void Sound()
    {
        Debug.Log("�Ŀ� ~");
    }
    public Cat()
    {
        age = 5;
        name = "Cat";
        Information();        
    }
}

public class Duck : Animal
{
    public override void Sound()
    {
        Debug.Log("�в� !");
    }
    public Duck()
    {
        age = 7;
        name = "Duck";
        Information();       
    }
}

    
// �Ϲ� �Լ� : ���� ���ε�(������ ����) , ���� �Լ� : ���� ���ε�(�� ���� ����)
