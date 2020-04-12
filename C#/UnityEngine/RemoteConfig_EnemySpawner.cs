// Brackeys: https://youtu.be/14njHI4CGgA
using System.Collections;
using System.Collections.Generic;
using Unity.RemoteConfig;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public struct userAttributes
    {

    }

    public struct appAttributes
    {

    }

    public float enemySpawnRate = .3f;
    public int enemyHealth = 100;

    public GameObject enemyPrefab;

    float timeToSpawn;

    public Transform[] spawnPoints;

    void Awake ()
    {
        ConfigManager.FetchCompleted += ApplyRemoteSettings;
        ConfigManager.FetchConfigs<userAttributes, appAttributes> (new userAttributes (), new appAttributes ());
    }

    void ApplyRemoteSettings (ConfigResponse response)
    {
        enemySpawnRate = ConfigManager.appConfig.GetFloat ("enemySpawnRate"); // RemoteConfig Key
        enemyHealth = ConfigManager.appConfig.GetInt ("enemyHealth");
    }

    // Start is called before the first frame update
    void Start ()
    {
        timeToSpawn = Time.time + 1f / enemySpawnRate;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Time.time >= timeToSpawn)
        {
            Spawn ();
            timeToSpawn = Time.time + 1f / enemySpawnRate;
        }
    }

    void Spawn ()
    {
        int pointIndex = Random.Range (0, spawnPoints.Length);
        Vector3 pos = spawnPoints[pointIndex].position;

        if (Physics.OverlapSphere (pos, 1f).Length > 0)
        {
            pointIndex++;
            pos = spawnPoints[pointIndex].position;
        }

        GameObject go = Instantiate (enemyPrefab, pos, Quaternion.identity);
        go.GetComponent<Unit> ().health = enemyHealth;
    }

    void OnDestroy ()
    {
        ConfigManager.FetchCompleted -= ApplyRemoteSettings;
    }
}