using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

  

    public Color myColor;
    public float rFloat = 0;
    public float gFloat = 255;
    public float bFloat = 0;
    public float aFloat = 255;
    // 0 to 1


    public Renderer myRenderer;


    // Start is called before the first frame update
    void Start()
    {
        aFloat = 1;
        myRenderer = gameObject.GetComponent<Renderer>();
         myColor = new Color(rFloat, gFloat, bFloat, aFloat);
    }

    // Update is called once per frame
    void Update()
    {
         if(transform.position.z < -30.0)
         {
                myRenderer.material.color = myColor;
         }
    }
}
