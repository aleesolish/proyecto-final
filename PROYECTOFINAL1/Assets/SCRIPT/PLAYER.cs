using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour {


    public float speed; //Para meterle la velocidad
    private bool moving;//Para saber si se esta moviendo 
    private Rigidbody2D Rb;//Para que le afecte la gravedad 
    public float high;//Cuanto va a saltar 


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
        Flip(_x)
        moving = (Mathf.Abs(_x)) > 0;
        if (moving){
            transform.position += new Vector3(_x, 0, 0) * speed * Time.deltaTime;

        }
    }

	private void Jump(){ //Hace que brinque

        if (Input.GetButtonDown("Jump"))
            Rb.velocity = new Vector3(0, 5, 0);
            
            
        }
    }


