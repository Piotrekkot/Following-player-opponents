using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public float rateTime = 5f; //co jaki czas ma się wykonywać
    float nextSpawnTime = 0f; //kiedy następne wykonanie
    GameObject[] respawns;
    
    public GameObject enemyPrefab;


    void Start()
    {
        respawns = GameObject.FindGameObjectsWithTag("Respawn");
    }

    void Update()
    {
        if (nextSpawnTime <= Time.time)
        {
            SpawnEnemy(); //coś co ma się wykonać co określony czas
            nextSpawnTime += rateTime;
        }
    }

    void SpawnEnemy()
    {
        int index = Random.Range(0, respawns.Length); //losowanie indeksu tablicy
        GameObject przeciwnik = Instantiate<GameObject>(enemyPrefab);
        przeciwnik.transform.position = respawns[index].transform.position;

    }
}
