using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(PlayerInput))]
public class PlayerController7PC : MonoBehaviour
{

    private Rigidbody2D myRB;
    private Animator myAnim;
        [SerializeField]
        private float speed;
 


    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
    
    }

    // Update is called once per frame
    void Update()
    {
        myRB.velocity = new  Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
       myAnim.SetFloat("moveX",myRB.velocity.x);
       myAnim.SetFloat("moveY",myRB.velocity.y);

    }
  
}
