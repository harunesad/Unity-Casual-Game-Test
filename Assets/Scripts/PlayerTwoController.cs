using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoController : MonoBehaviour
{
    public GameObject player;
    public GameObject prefab;
    public bool gameOver = false;

    private float moveSpeed = 9.0f;
    public int limit = 10;
    void Start()
    {

    }
    void Update()
    {
        Moving(true);
        if (player.transform.position.x < -limit)
        {
            player.transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        if (player.transform.position.x > limit)
        {
            player.transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
        ThrowEat(true);
    }
    public void Moving(bool resultPlayer)
    {
        if (resultPlayer == true)
        {
            if (Input.GetKey(KeyCode.A))
            {
                player.transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
            }

            if (Input.GetKey(KeyCode.D))
            {
                player.transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
            }
        }
    }
    public void ThrowEat(bool resultThrow)
    {
        if (resultThrow == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(prefab, player.transform.position, prefab.transform.rotation);
            }
        }
    }
}
