using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public Transform[] SpawnerPosition;
    public GameObject Enemy;
    public float timer=0;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        int i = (int)Random.Range(0, 4);
        GameObject[] a = GameObject.FindGameObjectsWithTag("Enemy");
        if (timer >= 10)
        {
            if (a.Length <= 5) Instantiate(Enemy, SpawnerPosition[i].position, SpawnerPosition[i].rotation);
            timer = 0;
        }
    }

}
