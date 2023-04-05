using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour
{
    [SerializeField] private float speed; // Variable de speed
    private Rigidbody2D rb; // permet d'appeler le component RigidBody 2D pour l'appeler plus rapidement avec un nouveau nom

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);  //Permet de bouger

        if (Input.GetKey(KeyCode.Space)) //Permet que si l'on appuie sur la barre d'espace, le joueur saute
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
    }
}
