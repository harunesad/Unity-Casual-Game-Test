using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    private PointAndHealth point;
    void Start()
    {
        point = GameObject.Find("Controller").GetComponent<PointAndHealth>();
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        point.skor++;
    }
}
