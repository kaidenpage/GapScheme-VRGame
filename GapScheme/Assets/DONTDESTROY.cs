using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DONTDESTROY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

}

    
