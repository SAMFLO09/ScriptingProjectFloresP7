using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int cupInTheSink = 4;


    // Start is called before the first frame update
    void Start()
    {
        while (cupInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupInTheSink--;
        }
    }
}