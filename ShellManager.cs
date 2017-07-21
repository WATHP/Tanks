using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShellManager : MonoBehaviour
{

    public GameObject Shell;
    public float ShotPower = 10.0f;
    public AudioClip ShotAudio;
    public AudioClip ChargeAudio;
    private new AudioSource audio;
    public Slider ChargeSlider;

    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
        ChargeSlider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {/*
        if (Input.GetKey(KeyCode.Space))
        {
            if (ShotPower >= 25)
            {
                ShotPower = 25;
                ChargeSlider.value = ShotPower;
            }
            else
            {
                ShotPower += Time.deltaTime * 10;
                ChargeSlider.value = ShotPower;
                if (audio.isPlaying)
                {
                    if (audio.clip == ChargeAudio)
                    {
                        return;
                    }
                    if (audio.clip == ShotAudio)
                    {
                        audio.Stop();
                    }
                }
                audio.clip = ChargeAudio;
                audio.Play();

            }

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ChargeSlider.value = 10;
           Instantiate(Shell, transform.position, transform.rotation).GetComponent<Rigidbody>().velocity = transform.forward * ShotPower;
            ShotPower = 10;
            if (audio.isPlaying)
            {
                if (audio.clip == ShotAudio)
                {
                    return;
                }
                if (audio.clip == ChargeAudio)
                {
                    audio.Stop();
                }
            }
            audio.clip = ShotAudio;
            audio.Play();
        }*/
    }

    public void Charge()
    {
        if (ShotPower >= 25)
        {
            ShotPower = 25;
            ChargeSlider.value = ShotPower;
        }
        else
        {
            ShotPower += Time.deltaTime * 10;
            ChargeSlider.value = ShotPower;
            if (audio.isPlaying)
            {
                if (audio.clip == ChargeAudio)
                {
                    return;
                }
                if (audio.clip == ShotAudio)
                {
                    audio.Stop();
                }
            }
            audio.clip = ChargeAudio;
            audio.Play();

        }
    }

    public void Shot()
    {
        ChargeSlider.value = 10;
        GameObject a = Instantiate(Shell, transform.position, transform.rotation);
        a.GetComponent<Rigidbody>().velocity = transform.forward * ShotPower;
        a.GetComponent<Shell>().n = 0;
        
        ShotPower = 10;
        if (audio.isPlaying)
        {
            if (audio.clip == ShotAudio)
            {
                return;
            }
            if (audio.clip == ChargeAudio)
            {
                audio.Stop();
            }
        }
        audio.clip = ShotAudio;
        audio.Play();
    }
}
