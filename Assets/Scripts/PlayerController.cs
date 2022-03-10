using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject car;
    private float speed = 9.0f;
    private float leftLimit = -8.0f;
    private float rightLimit = 8.0f;
    private float rotateSpeed = 0.01f;
    private float finish = 160;
    void Start()
    {
        
    }
    void Update()
    {
        if (car.transform.position.z < finish)
        {
            Moving(true);
        }
        else
        {
            Moving(false);
        }
    }
    public void Moving(bool result)
    {
        if (result == true)
        {
            car.transform.Translate(Vector3.forward * Time.deltaTime * speed);
            if (car.transform.position.x > leftLimit)
            {
                if (Input.GetKey(KeyCode.A))
                {
                    car.transform.Translate(Vector3.left * Time.deltaTime * speed);
                    car.transform.Rotate(0, -5 * rotateSpeed, 0);
                }
            }
            if (car.transform.position.x < leftLimit)
            {
                if (car.transform.rotation.y < 0)
                {
                    car.transform.Rotate(0, 50 * rotateSpeed, 0);
                }
            }
            if (car.transform.position.x < rightLimit)
            {
                if (Input.GetKey(KeyCode.D))
                {
                    car.transform.Translate(Vector3.right * Time.deltaTime * speed);
                    car.transform.Rotate(0, 5 * rotateSpeed, 0);
                }
            }
            if (car.transform.position.x > rightLimit)
            {
                if (car.transform.rotation.y > 0)
                {
                    car.transform.Rotate(0, -50 * rotateSpeed, 0);
                }
            }
        }
    }
}
