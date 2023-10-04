using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviorScript : MonoBehaviour
{
   public Vector3 point;
   public Vector3 axis;
   public float angle;

   void Start()
   {
      
   }

   void Update()
   {
      transform.RotateAround(point, axis, angle);
   }
}