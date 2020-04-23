using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public struct ECSMoveSpeedComponent : IComponentData
{
    public float moveSpeed;
}