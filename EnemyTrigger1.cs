﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger1 : MonoBehaviour {

    public GameObject ShellBurnPosition;
    private float ShotPower;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ShotPower = 10;
            ShellBurnPosition.GetComponent<EnemyShellManager>().attack(ShotPower);
        }
        StartCoroutine(StopAttack());
    }

    IEnumerator StopAttack()
    {
        yield return new WaitForSeconds(1.5f);
    }
}
