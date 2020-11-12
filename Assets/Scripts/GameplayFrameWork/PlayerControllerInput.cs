using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class AxisMove : UnityEvent<Vector2> { };
public class PlayerControllerInput : MonoBehaviour
{
    public AxisMove OnAxisMove;
    Vector2 targetDirection;
    void ReadInput()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        float verticalValue = Input.GetAxis("Vertical");



        OnAxisMove?.Invoke(targetDirection);



    }
    // Update is called once per frame
    void Update()
    {
        ReadInput();
    }
}
