using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {

    public float hp = 100;
    private float maxhp;
    public Slider HealthSlider;
    public Canvas GameOverCanvas;

	// Use this for initialization
	void Start () {
        maxhp = hp;
	}
	
	// Update is called once per frame
	void Update () {
        HealthSlider.value = (float)hp / maxhp;
        if (hp <= 0) hp = 0;
        if (hp == 0)
        {
            ParticleSystem a = GameObject.Find("TankExplosion").GetComponent<ParticleSystem>();
            a.Play();
            Destroy(this.gameObject, 0.3f);
            GetComponent<TankHealth>().enabled = false;
            GetComponent<TankController>().enabled = false;
            GameOverCanvas.enabled = true;
        }
    }

    public void TakeDamge()
    {
        hp -= 10;
    }
}
