using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factorial : MonoBehaviour
{
    public int value;

    int result = 1;
    void Start()
    {
        //for (de�i�ken tan�m�; ko�ul; art�� miktar�)

        for(int i = 1; i <= value; i++)
        {
            result *= i;
        }

        //for (int i = value; i > 0; i--)
        //{
        //    result *= i;
        //}

        print(result);

    }

    // Update is called once per frame
    void Update()
    {
        print(value);
    }
}
