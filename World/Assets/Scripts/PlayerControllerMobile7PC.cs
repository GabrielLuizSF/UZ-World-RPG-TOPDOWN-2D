using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(PlayerController7PC))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(PlayerInput))]
public class PlayerControllerMobile7PC : MonoBehaviour
{
    PlayerController7PC  playerMovement;
    SpriteRenderer spriteRenderer;
    PlayerInput playerInput;

    private Rigidbody2D myRB;
    private Animator myAnim;

        [SerializeField]
    private float speed = 100;
 


    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerController7PC>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
      Vector2 movementInput = playerInput.GetMovementInput();
      playerMovement.ProcessMovementInput(new Vector2(movementInput));
 
     
    }
}
