using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour {

    Rigidbody2D rb;
    
	// Use this for initialization
	void Start () {
	    rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D coll) {
	    GameObject touched = coll.gameObject;
        if (touched.tag == "Player") {
            //reverse y velocity
            rb.velocity = new Vector2(0, 100);
        } else if (touched.tag == "brick") {
            //remove brick! (keep for later for reuse!)
            touched.SetActive(false);
            rb.velocity = new Vector2(0, -100);
        }
    }
}