using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class Variables : MonoBehaviour
{
    int myInt = 5;

     void Start()
    {
      myInt = MulitiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    private int MulitiplyByTwo(int myInt)
    {
        throw new NotImplementedException();
    }

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
