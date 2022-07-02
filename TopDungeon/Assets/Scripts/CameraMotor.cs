﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt;
    public float boundX = 0.15f;
    public float boundY = 0.05f;
    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;
        float deltaX = lookAt.position.x - transform.position.x;
        if(deltaX>boundX || deltaX<-boundX)
        {
            if (lookAt.position.x > transform.position.x)
            {
                delta.x = deltaX - boundX;
            }
            if (lookAt.position.x < transform.position.x)
            {
                delta.x = deltaX + boundX;
            } 
        }
        float deltaY = lookAt.position.y - transform.position.y;
        if (deltaY > boundY || deltaY < -boundY)
        {
            if (lookAt.position.y > transform.position.y)
            {
                delta.y = deltaY - boundY;
            }
            if (lookAt.position.y < transform.position.y)
            {
                delta.y = deltaY + boundY;
            }
        }
        transform.position += delta;
    }
}
