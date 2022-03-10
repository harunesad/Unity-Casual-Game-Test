using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointAndHealth : MonoBehaviour
{
    public Text point, health;
    public float hearth = 3;
    public float skor = 0;
    void Start()
    {
        
    }
    void Update()
    {
        health.text = "Can: " + hearth;
        point.text = "Puan: " + skor;
    }
}
