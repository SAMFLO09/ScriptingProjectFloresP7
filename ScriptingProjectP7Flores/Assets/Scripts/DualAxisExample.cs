using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DualAxisExample : MonoBehaviour
{
    //public Text horizontalValueDisplayText;
   //public Text verticalVauleDisplayText;
    public float hRange;
    public float vRange;
    private float vPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;

        transform.position = new Vector3(xPos, 0, vPos);
        Debug.Log(h.ToString("F2"));
       Debug.Log(v.ToString("F2"));
    }
}
