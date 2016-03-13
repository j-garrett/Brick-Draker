using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour {

    Rigidbody2D rb;
    
	// Use this for initialization
	void Start () {
	    rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	//void OnTriggerEnter2D (Collider2D coll) {
    void OnCollisionEnter2D(Collision2D coll) {
	    GameObject touched = coll.gameObject;
        print("Touched " + touched.tag);
        if (touched.tag == "Player") {
            //reverse y velocity
            rb.velocity = new Vector2(2, 200);
        } else if (touched.tag == "brick") {
            //remove brick! (keep for later for reuse!)
            touched.SetActive(false);
 
            Vector2 velocity = rb.velocity;
            print("Velocity: " + velocity);
            if (velocity.y > 0) {
                velocity.y = -100;
            } else {
                //velocity.y = System.Math.Max(20, velocity.y * -1.0f);
                velocity.y = 100;
            }
            
            velocity.x = 2;
            //rb.velocity = velocity;
        }
    }
}