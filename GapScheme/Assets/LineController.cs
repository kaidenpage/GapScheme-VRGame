using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{

    private LineRenderer _lineRenderer;

    [SerializeField] private Transform[] Waypoints;
    // Start is called before the first frame update
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        _lineRenderer.positionCount = Waypoints.Length;
        for(int i = 0; i < Waypoints.Length; i++)
        {
            _lineRenderer.SetPosition(i, Waypoints[i].position);
        }
    }
}
