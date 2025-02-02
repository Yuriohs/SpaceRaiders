﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="ShipStats", menuName="ShipStats")]
public class SO_ShipStats : ScriptableObject
{
    [Header("Vehicle Settings")]
    [SerializeField] internal float turnSpeed;
    [SerializeField] internal float drift, maxSpeed, enginePower, shipVelocity;
    [SerializeField] internal float rampSpeed = 1;


}
