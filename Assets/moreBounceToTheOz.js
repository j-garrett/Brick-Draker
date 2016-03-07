#pragma strict

var rb : Rigidbody2D;

function Start () {
    rb = GetComponent.<Rigidbody2D>();
}

function Update () {

}

function OnCollisionEnter2D(coll: Collision2D){
    var touched = coll.gameObject;
    if (touched.tag == "Player") {
        //reverse y velocity
        rb.velocity = Vector2(0, 100);
    }else if (touched.tag == "brick") {
    	//remove brick! (keep for later for reuse!)
    	touched.SetActive(false);
    	rb.velocity = Vector2(0, -100);
    }
}