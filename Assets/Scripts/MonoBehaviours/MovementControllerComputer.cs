using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControllerComputer : MonoBehaviour
{
    public float movementSpeed = 10f;
    public VectorValue startingPosition;
    Vector2 movement = new Vector2();
    //1
    Animator animator;
    //2C    
    string animationState = "AnimationState";
    Rigidbody2D rb2d;
    //3
    enum CharStates{
        walkRight = 1,
        walkDown = 2,
        walkLeft = 3,
        walkUp = 4,
        runRight = 5,
        runDown = 6,
        runLeft = 7,
        runUp = 8,
        idleRight = 9
    }
    private void Start()
    {
        //4
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        //transform.position = startingPosition.initialValue;
    }
    private void Update(){
        //5
        UpdateState();
    }
    
    void FixedUpdate(){
        //6
        MoveCharacter();
    }
    private void MoveCharacter()
    {
        movement.x= Input.GetAxisRaw("Horizontal");
        movement.y= Input.GetAxisRaw("Vertical");
        
        movement.Normalize();
        rb2d.velocity = movement * movementSpeed;
    }
    private void UpdateState()
    {
        //7
        if(movement.x > 0)
        {
            animator.SetInteger(animationState, (int)
            CharStates.walkRight);
        }
        else if(movement.x < 0)
        {
            animator.SetInteger(animationState, (int)
            CharStates.walkLeft);
        }
        else if(movement.y < 0)
        {
            animator.SetInteger(animationState, (int)
            CharStates.walkDown);
        }
        else if(movement.y > 0)
        {
            animator.SetInteger(animationState, (int)
            CharStates.walkUp);
        }
    }
}
