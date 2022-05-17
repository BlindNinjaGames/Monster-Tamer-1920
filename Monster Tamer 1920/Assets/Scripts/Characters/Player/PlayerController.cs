using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    bool isMoving = false;
    Vector2 input;   //Using a Vector2 variable lets us save transform.position data.
    [SerializeField] LayerMask collisionsLayer;
    [SerializeField] LayerMask grassLayer;
    [SerializeField] LayerMask interactableLayer;

    WillSystem willSystem;

    private void Awake()
    {
        willSystem = GetComponent<WillSystem>();
    }

    public void HandleUpdate()
    {
        if (!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            // remove diagonal movement. So only x or y can be not zero at any given time. If both aren't zero then we move diagonally and we don't want that.
            if (input.x != 0)
            {
                input.y = 0;
            }

            if (input != Vector2.zero)
            {
                var targetPos = transform.position;   //"var" variable types can pretty much be anything.
                targetPos.x += input.x;
                targetPos.y += input.y;

                if (IsWalkable(targetPos)) //Only activate if IsWalkable's targetPos returns true
                {
                    StartCoroutine(Move(targetPos));
                }
            }
        }
    }

    IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;

        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }

        transform.position = targetPos;

        isMoving = false;

        CheckForEncounters();
    }

    void CheckForEncounters()
    {
        if (Physics2D.OverlapCircle(transform.position, 0.2f, grassLayer) != null)
        { //YOU CAN ADD THINGS LIKE PARTICLE EFFECTS WHILE WALKING HERE AND RUSTLING SOUND EFFECT
            if (Random.Range(1, 101) <= 5)
            {
                Debug.Log("Encounter triggered");
                willSystem.playerCurrentWillPoints += willSystem.catchWillPoints;
                willSystem.GetPlayerRank();
            }
        }
    }



    private bool IsWalkable(Vector3 targetPos)
    {
        if (Physics2D.OverlapCircle(targetPos, 0.1f, collisionsLayer | interactableLayer) != null)  //If the overlap circle collides with the collisions layer then return the targetPos as false
        {
            return false;
        }

        return true;
    }

}


/*
  if(!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            if(input != Vector2.zero)
            {
                var targetPosition = transform.position;   //"var" variable types can pretty much be anything.
                targetPosition.x += input.x;
                targetPosition.y += input.y;
            }
        }


The targetPosition is the current position of the player plus the input position. Since we're using "GetAxisRaw", the input
will always be 1 or -1. So basically, we're getting the current position of the player and then adding 1 to it or -1 depending
on what direction we try to move. And we don't need to set key instructions because GetAxisRaw("Horizontal") and Vertical are
programmed into Unity by default under Edit > Project Settings > Input Manager.


 IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;

        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }

        transform.position = targetPos;

        isMoving = false;

        CheckForEncounters();
    }

 "sqrMagnitude" returns the length of this vector (Read Only).

The length of the vector is square root of (x*x+y*y+z*z).

Mathf.Epsilon is basically as close to zero as you can get without it actually being zero.

So, while the difference between the target position and the player's current position is bigger than nearly zero, we want
to MoveTowards the target position.


 private bool IsWalkable(Vector3 targetPos)
    {
        if (Physics2D.OverlapCircle(targetPos, 0.2f, collisionsLayer) != null)
        {
            return false;
        }
        return true;
    }

If the overlap circle collides with the collisions layer then return the targetPos as false

void CheckForEncounters()
    {
        if (Physics2D.OverlapCircle(transform.position, 0.2f, collisionsLayer) != null)
        {
            if(Random.Range(1, 101) <= 5)
            {
                Debug.Log("Encounter triggered");
            }
        }
    }

With CheckForEncounters() at the end of the Move function, this will trigger the function every time you move sucessfully.
If your current position, which is determined by getting the transform.position, is on the grassLayer then run a random number
between 1 and 100 (101 will never be called). If that number is less than or equal to 5 then do a thing.
 */