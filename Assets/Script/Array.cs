using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Array : MonoBehaviour
{
    string[] array1 = new string[4];
    float[] array2 = new float[4] { 1f, 2f, 3f, 4f };
    int[] array3 = new int[4] { 1, 2, 3, 4};
    GameObject[] array4 = new GameObject[4];

    void Start()
    {

    foreach (float array2f in array2)
      {
        Debug.Log("array2: " + array2f);
      }

        Debug.Log("array1: " + array1.Length);
       // array2[1] = 3f;
       // array2[3] = 1f;
        array3[3] = 2;
        array3[2] = 3;
        array4 = GameObject.FindGameObjectsWithTag("BlueImage");
        array4[2].GetComponent<Image>().color = Color.blue;

 
    


//ausgeben der Werte; arrays als Debug ausgeben, 2 werte direkt ändern, gmaeobejctimages anlegen, zuweisen und farbe ändern
    }
}