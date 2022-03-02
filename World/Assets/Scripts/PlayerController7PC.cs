using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController7PC : MonoBehaviour
{

    private Rigidbody2D myRB;
        [SerializeField]
        private float speed;



    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();

    
    }
    

    // Update is called once per frame
    void Update()
    {
        myRB.velocity = new  Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;


    }
}
