using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
    }
    GetComponent<Renderer>().material.color = Color.red;
    }
if (Input.GetKeyDown(KeyCode.G))
    {
    GetComponent<Renderer>().material.color = Color.green;
}

object GetComponent<T>()
{
    throw new NotImplementedException();
}

if (Input.GetKeyDown(KeyCode.B))
    GetComponent<Renderer>().material.color = Color.blue;
   }
  }
}
     