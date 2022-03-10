using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMove : MonoBehaviour
{
    public float foodSpeed = 20.0f;
    private float forwardLimit = 30.0f;
    private float backLimit = -15.0f;
    private PointAndHealth health;
    private PlayerTwoController twoController;
    void Start()
    {
        health = GameObject.Find("Controller").GetComponent<PointAndHealth>();
        twoController = GameObject.Find("Controller").GetComponent<PlayerTwoController>();
    }
    void Update()
    {
        if (gameObject.transform.position.z > forwardLimit)
        {
            Destroy(gameObject);
        }
        else if (gameObject.transform.position.z < backLimit)
        {
            Destroy(gameObject);
            if (health.hearth > 0)
            {
                health.hearth--;
            }
        }
        else if (health.hearth == 0 && twoController.gameOver == false)
        {
            twoController.enabled = false;
            twoController.gameOver = true;
        }
        else if (twoController.gameOver == false)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * foodSpeed);
        }
    }
}
