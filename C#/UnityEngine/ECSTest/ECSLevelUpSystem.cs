using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class ECSLevelUpSystem : ComponentSystem
{
    protected override void OnUpdate ()
    {
        Entities.ForEach ((ref ECSLevelComponent levelComponent) =>
        {
            levelComponent.level += 1f * Time.deltaTime;
            Debug.Log (levelComponent.level);
        });
    }

}