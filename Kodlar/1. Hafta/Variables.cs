using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int age; // integer, tam sayı
    public float chance; // floating point, ondalıklı sayı
    public string isim; // karakter dizisi,yazı
    public bool isMale; // true,false
    
    void Start()
    {
        print("Yaş " + age);
        print("Şans " + chance);
        print("Isim " + isim);

        //age = 5;

        if (isMale == true)
        {
            print("Erkek");
        }
        else if(isMale == false)
        {
            print("Kadın");
        }


        //if (age < 10)
        //{

        //}else if(age < 20)
        //{

        //}
        

        print("test");
    }

    // Update is called once per frame
    void Update()
    {
        print("Hello World");   
    }
}
