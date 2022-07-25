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
        Debug.Log("울음소리");
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
        Debug.Log("멍멍 !");
    }
    public Dog() // private void Start() 도 가능
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
        Debug.Log("냐옹 ~");
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
        Debug.Log("꽥꽥 !");
    }
    public Duck()
    {
        age = 7;
        name = "Duck";
        Information();       
    }
}

    
// 일반 함수 : 정적 바인딩(컴파일 시점) , 가상 함수 : 동적 바인딩(런 실행 시점)
