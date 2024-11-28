using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverdosedFool : Fool
{
    public float Angle;
    public float MaxAngle;
    public bool IsGoingRight = true;

    private Quaternion _startRotation;
    protected override void Start()
    {
        base.Start();
        _startRotation = transform.rotation;
    }
    protected override void DoMovement()
    {
        if (IsGoingRight)
        {
            transform.Rotate(0, Angle * Time.deltaTime, 0);

        }
        else
        {
            transform.Rotate(0, -Angle * Time.deltaTime, 0);
        }

        if(Quaternion.Angle(_startRotation, transform.rotation) > MaxAngle)
        {
            IsGoingRight = !IsGoingRight;
        }
        base.DoMovement();
    }
}
