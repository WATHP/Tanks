using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyShellManager : MonoBehaviour {

    public GameObject Shell;
    private new AudioSource audio;
    public GameObject Enemy;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void attack(float ShotPower)
    {
        Enemy.transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform.position);
        GameObject b = Instantiate(Shell, transform.position, transform.rotation);
        b.GetComponent<Rigidbody>().velocity = transform.forward * ShotPower;
        b.GetComponent<Shell>().n = 1;
        if (audio.isPlaying)
        {
                return;
        }
        audio.Play();
    } 
}
