using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour {


    public AudioClip MAudio;
    public AudioClip IAudio;
    private new AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
    }

    /*// Update is called once per frame
     * void Update () {

    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");

    GetComponent<Rigidbody>().MovePosition(transform.position + transform.forward * v * 5 * Time.deltaTime);
    transform.Rotate(Vector3.up * h * 120 * Time.deltaTime);

    if (h != 0 || v != 0) 
    {
        if (audio.isPlaying) 
        {
            if (audio.clip == MoveAudio)
            {
                return;
            }
            if (audio.clip == IdleAudio)
            {
                audio.Stop();
            }
        }
        audio.clip = MoveAudio;
        audio.Play();

    }
    else
    {
        if (audio.isPlaying)
        {
            if (audio.clip == MoveAudio)
            {
                audio.Stop();
            }
            if (audio.clip == IdleAudio)
            {
                return;
            }
        }
        audio.clip = IdleAudio;
        audio.Play();
    }


}*/

    public void MoveAudio()
    {
        if (audio.isPlaying)
        {
            if (audio.clip == MAudio)
            {
                return;
            }
            if (audio.clip == IAudio)
            {
                audio.Stop();
            }
        }
        audio.clip = MAudio;
        audio.Play();
    }

    public void IdleAudio()
    {
        if (audio.isPlaying)
        {
            if (audio.clip == MAudio)
            {
                audio.Stop();
            }
            if (audio.clip == IAudio)
            {
                return;
            }
        }
        audio.clip = IAudio;
        audio.Play();
    }
}
