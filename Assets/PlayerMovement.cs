using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private int movementVector = 2;
    public float delayInterval = .15f; // seconds
    public GameObject _playerObject;
    public static bool forwardMovementStart = false;
    public static bool backwardMovementStart = false;

    private IEnumerator _spawnCoroutine;

    private static bool moveUp;
    private static bool moveDown;
    public static bool rotatePlayerLeft;
    public static bool rotatePlayerRight;

    void Awake()
    {
        _spawnCoroutine = MovePlayerWithDelay();

    }

    private IEnumerator MovePlayerWithDelay()
    {
        while (true)
        {
            MovePlayer();
            yield return new WaitForSeconds(delayInterval);
        }
    }

    public void StartPlayerForwardMovement()
    {
       // StartCoroutine(_spawnCoroutine);
        forwardMovementStart = true;
    }

    public void StopPlayerForwardMovement()
    {
       // StopAllCoroutines();
        forwardMovementStart = false;
    }

    public void StartPlayerBackwardMovement()
    {
        backwardMovementStart = true;
    }

    public void StopPlayerBackwardMovement()
    {
        backwardMovementStart = false;
    }

    public bool CheckIfMoveUpIsActive()
    {
        
        bool temp = moveUp;
        moveUp = false;
        return temp;

    }

    public void MovePlayerUp()
    {
        Debug.Log("Move Up requested");
        moveUp = true;
    }

    public void MovePlayerDown()
    {
        Debug.Log("Move down requested");
        moveDown = true;
    }

    public bool CheckIfMoveDownIsActive()
    {

        bool temp = moveDown;
        moveDown = false;
        return temp;
    }

    public void StartRotatePlayerLeft()
    {
        rotatePlayerLeft = true;
    }

    public void StartRotatePlayerRight()
    {
        rotatePlayerRight = true;
    }

    public void StopRotatePlayerRight()
    {
        rotatePlayerRight = false;
    }

    public void StopRotatePlayerLeft()
    {
        rotatePlayerLeft = false;
    }

    private void MovePlayer()
    {
        Vector3 position = _playerObject.transform.position;
        position.x = position.x - movementVector;
        _playerObject.transform.position = position;
    }


    public void printMessageDeactivated()
    {
        print("Hello world deactivate");
    }

    public void printMessageActivated()
    {
        print("Hello world Active");
    }
}
