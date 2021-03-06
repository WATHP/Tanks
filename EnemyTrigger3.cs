﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger3 : MonoBehaviour {

    public GameObject ShellBurnPosition;
    private float ShotPower;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ShotPower = Random.Range(16, 20);
            ShellBurnPosition.GetComponent<EnemyShellManager>().attack(ShotPower);
        }
        StartCoroutine(StopAttack());
    }

    IEnumerator StopAttack()
    {
        yield return new WaitForSeconds(1.5f);
    }
}
