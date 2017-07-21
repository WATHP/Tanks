using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {

    public float n;
    private new AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player" && n == 1) 
        {
            collision.collider.GetComponent<TankHealth>().TakeDamge();
        }
        if (collision.collider.tag == "Enemy" && n == 0) 
        {
            collision.collider.GetComponent<EnemyHealth>().TakeDamge();
        }
        ParticleSystem a = GameObject.Find("ShellExplosion").GetComponent<ParticleSystem>();
        a.Play();
        audio.Play();
        Destroy(this.gameObject, 0.25f);
    }
}
