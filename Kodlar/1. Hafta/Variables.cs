using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int age;
    public float chance;
    public string names;
    public bool isMale;
    
    void Start()
    {
        print("Ya� " + age);
        print("�ans " + chance);
        print("�sim " + names);

        age = 5;

        if (isMale == true)
        {
            print("Erkek");
        }
        else if(isMale == false)
        {
            print("Kad�n");
        }

        if (age < 10)
        {

        }else if(age < 20)
        {

        }
        

        print("test");
    }

    // Update is called once per frame
    void Update()
    {
        print("Hello World");   
    }
}
