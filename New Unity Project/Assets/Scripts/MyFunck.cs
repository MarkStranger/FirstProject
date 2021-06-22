using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFunck : MonoBehaviour
{

    void Start()
    {
        PrintWelcome();
        PrintWelcome();
        PrintWelcome();

        Divide(5f, 2f);
        Divide(10f, 3f);
        Divide(5, 2);
        Divide(10, 3);


    }


    private void PrintWelcome()
    {
        print("Привет");
        print("Добро пожаловать");
    }
    private void Divide(float num1, float num2)
    {
        float rez = num1 / num2;
        print(rez);

    }
    private void Divide(int num1, int num2)
    {
        float rez = num1 / num2;
        print(rez);


    }

    private float checking;
    
    

    private void Checking(int age,string name)
    {




       if(age >= 18)
        {
            print("Разрешен");

        }
       else
        {
            print("Запрещен");
            print("Ждите" + (18 - age));
        }

    }

    private void countSquere(int width, int height)
    {
        float rez = width / height/100;
        print(rez);


    }



}
    

