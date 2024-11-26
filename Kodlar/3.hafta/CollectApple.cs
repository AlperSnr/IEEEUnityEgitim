using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectApple : MonoBehaviour
{
    public TMP_Text text;
    private int elmaSayisi = 0;
    private void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Elma"))
        {
            elmaSayisi += 1;
            Destroy(other.gameObject);
            text.SetText("Elma sayısı: " + elmaSayisi.ToString());
        }

        print("Elma değdi");
    }

    ////private void OnTriggerStay(Collider other)
    ////{
    ////    print("stay");
    ////}

    ////private void OnTriggerExit(Collider other)
    ////{
    ////    print("exit");
    ////}
}
