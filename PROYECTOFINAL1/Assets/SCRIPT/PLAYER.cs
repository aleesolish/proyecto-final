using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour {


    public float speed; //Para meterle la velocidad
    private bool moving;//Para saber si se esta moviendo 
    private Rigidbody2D Rb;//Para que le afecte la gravedad 
    private bool grounded;//Para saber si al brincar toca el suelo 
    public float high;//Cuanto va a saltar 
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask ground;

	// Use this for initialization
	void Start () {

        Rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
        Walk();
        Jump();

	}

    private void Walk(){
        float _x = Input.GetAxis("Horizontal");
        //Flip(x);// para que se gire el sprite 
        moving = (Mathf.Abs(_x)) > 0;
        if (moving){
            transform.position += new Vector3(_x, 0, 0) * speed * Time.deltaTime;

        }
    }

	private void FixedUpdate()
	{
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, ground);
	}

	private void Jump(){
        if (Input.GetKeyDown(KeyCode.Space)&& grounded) {
            Rb.velocity = new Vector2(0, high);
            
        }
    }
}

