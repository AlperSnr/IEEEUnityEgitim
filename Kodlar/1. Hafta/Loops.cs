using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int sayi = 5;
    public int can = 10;

    public int artisMiktari = 2;
    // Start is called before the first frame update
    void Start()
    {

        if(sayi % 10 == 3)
        {
            print("Test");
        }

        //sayi++;
        //sayi = sayi + 1;
        sayi += 1; // üçü de aynı işlevi görür.

        for (int i = 0;i < 10;i++)
        {
            print(i);
        }

        while (can > 0)
        {
            print("Can : " + can);
            can = can - 1;
        }

        print("test");


    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
