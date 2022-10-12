using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballForce;
    bool gameStarted = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameStarted == false)
        {
            transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce (new Vector2 (ballForce, ballForce));
            gameStarted = true;
        }
    }
}
