#pragma strict

var rb : Rigidbody2D;

function Start () {
	rb = GetComponent.<Rigidbody2D>();
}

function Update () {
	if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
		rb.velocity = Vector2(-10, 0);
	}else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
		rb.velocity = Vector2(10, 0);
	}else{
		rb.velocity = Vector2(0, 0);
	}
}