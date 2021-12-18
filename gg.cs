using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gg : MonoBehaviour {
    public float speed = 50.0f;
    private Rigidbody2D rb;
    public GameObject player;
    private bool faceRight = false;
    public Transform кулак;
    public AudioSource Au;
 
    void Start () {
        rb = GetComponent<Rigidbody2D> ();
        Au = GetComponent<AudioSource> ();
    }
    
    void Update () {
        float moveX = 0;
        if ((Input.GetKey (KeyCode.A)) || (Input.GetKey (KeyCode.D))) {
            moveX = Input.GetAxis("Horizontal");
            if (moveX > 0 && faceRight)
                flip();
            if (moveX < 0 && !faceRight)
                flip();
        }
        rb.MovePosition (rb.position + Vector2.right * speed * moveX * Time.deltaTime);
        
        if (Input.GetKey (KeyCode.S)) {
            rb.AddForce (Vector2.up * 20);
        }
        if (Input.GetKeyDown (KeyCode.E)) {
            Strike ();
            player.GetComponent<Animator>().SetTrigger ("Attak");
            Au.Play ();
        }
        
    }

    void flip()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

    void Strike() {
        float posX = this.transform.position.x;
        float posY = this.transform.position.y;
        Instantiate (кулак, new Vector3 (posX, posY, 0), this.transform.rotation);
    }
}