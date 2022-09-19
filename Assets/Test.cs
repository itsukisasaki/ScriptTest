using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {

        int[] array = { 1, 2, 3, 4, 5 };

        int Length;
        Length = array.Length;

        for (int i = 0; i < Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 0; i < Length; i++)
        {
            Debug.Log(array[4 - i]);
        }

    }

    void Update()
    {

    }
}