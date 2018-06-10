using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintMessage : MonoBehaviour
{

    private int movementVector = 2;


    public void MovePlayer(GameObject g)
    {
        Vector3 position = g.transform.position;
        position.x = position.x - movementVector;
        g.transform.position = position;
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
