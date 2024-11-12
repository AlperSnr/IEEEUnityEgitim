using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject küp;
    public Vector3 vektör;

    public float speed;

    private int sayi;
    void Start()
    {
        küp.transform.position += vektör;

        vektör.z = 5 * 10;

        vektör = new Vector3(5,5,5);
    }

    void Update()
    {
        //Input.GetKey() verilen key için o an basılı olup olmadığının bilgisini verir.
        //Time.deltaTime = 1/FPS değerini verir.
        if (Input.GetKey(KeyCode.W))
        {
            küp.transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }else if (Input.GetKey(KeyCode.S))
        {
            küp.transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            küp.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }else if (Input.GetKey(KeyCode.A))
        {
            küp.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
        
    }
}
