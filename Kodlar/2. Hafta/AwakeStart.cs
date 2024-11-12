using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeStart : MonoBehaviour
{
    public int sayi = 15;

    private int sayi2;

    public float ondalikli = 0.5f;

    public bool doğru = false;

    public string yazi = "Alper";


    private void Awake()
    {
        print("awake");
    }
    void Start()
    {
        print("start");
    }

    // Update is called once per frame
    void Update()
    {
        print("update");
    }
}
