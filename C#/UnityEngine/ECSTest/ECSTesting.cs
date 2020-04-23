using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using Unity.Rendering;
using Unity.Transforms;
using UnityEngine;

public class ECSTesting : MonoBehaviour
{
    [SerializeField] private Mesh mesh;
    [SerializeField] private Material material;

    private void Start ()
    {
        EntityManager entityManager = World.Active.EntityManager;

        EntityArchetype entityArchetype = entityManager.CreateArchetype (
            typeof (ECSLevelComponent),
            typeof (Translation),
            typeof (RenderMesh),
            typeof (LocalToWorld),
            typeof (ECSMoveSpeedComponent)
        );

        Entity entity = entityManager.CreateEntity (entityArchetype);

        NativeArray<Entity> entityArray = new NativeArray<Entity> (100, Allocator.Temp);

        entityManager.CreateArchetype (entityArchetype, entityArray);

        for (int i = 0; i < entityArray.Length; i++)
        {
            Entity entity = entityArray[i];

            entityManager.SetComponentData (entity, new ECSLevelComponent { level = UnityEngine.Random.Range (10, 20) });
            entityManager.SetComponentData (entity, new ECSMoveSpeedComponent { moveSpeed = UnityEngine.Random.Range (1f, 2f) });
            entityManager.SetComponentData (entity, new Translation { Value = new float3 (UnityEngine.Random.Range (-7, 7f)), UnityEngine.Random.Range (-5f, 5f), 0 });

            entityManager.SetSharedComponentData (entity, new RenderMesh
            {
                mesh = mesh,
                    material = material;
            });
        }

        entityArray.Dispose ();

    }
}