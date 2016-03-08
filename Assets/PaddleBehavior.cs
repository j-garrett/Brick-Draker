using UnityEngine;
using System.Collections;

public class PaddleBehavior : MonoBehaviour {

    Rigidbody2D rb;
    
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
		    rb.velocity = new Vector2(-10, 0);
	    } else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
		    rb.velocity = new Vector2(10, 0);
	    } else {
		    rb.velocity = new Vector2(0, 0);
	    }
	}
}