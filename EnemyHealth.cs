using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

    public float hp = 50;
    private float maxhp;
    public Slider HealthSlider;
    private Text text;
    public ParticleSystem p;

    // Use this for initialization
    void Start()
    {
        maxhp = hp;
        text = GameObject.Find("PointCanvas").GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0) hp = 0;
        HealthSlider.value = (float)hp / maxhp;
        if (hp == 0)
        {
            int j;
            int.TryParse(text.text, out j);
            j += 10;
            text.text = j.ToString();
            p.Play();
            GetComponent<EnemyHealth>().enabled = false;
            GetComponent<EnemyMove>().enabled = false;
            Destroy(this.gameObject, 0.3f);

        }
    }

    public void TakeDamge()
    {
        hp -= 10;
    }
}
