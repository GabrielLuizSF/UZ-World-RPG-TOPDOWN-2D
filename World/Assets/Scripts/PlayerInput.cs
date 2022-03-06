using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(PlayerController7PC))]
[RequireComponent(typeof(PlayerControllerMobile7PC))]
public class PlayerInput : MonoBehaviour
{

    private Rigidbody2D myRB;
    private Animator myAnim;
        [SerializeField]
        private float speed;
 
 public Vector2 GetMovementInput(){

      float horizontalInput = Input.GetAxisRaw("Horizontal");
      float verticalInput = Input.GetAxisRaw("Vertical");

  return new Vector2 movementInput(horizontalInput,verticalInput);
 }

}
