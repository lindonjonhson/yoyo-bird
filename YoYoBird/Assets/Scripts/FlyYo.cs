using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyYo : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 2;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // The 0 means left click
        if(Input.GetMouseButtonDown(0)){
            // Jump
            rb.velocity = Vector2.up * velocity;
        }
    }

    // This method is automatically called when we hit anything
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
