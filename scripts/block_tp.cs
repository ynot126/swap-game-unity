using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_tp : MonoBehaviour
{
    private GameObject player;
    private Animator block_anim, player_anim;
    private AudioSource player_audio;
    private ParticleSystem player_ps,block_ps;
    void Awake()
    {
        player = GameObject.FindWithTag("Player");
        player_anim = player.GetComponent<Animator>();
        block_anim = GetComponent<Animator>();
        player_audio= player.GetComponent<AudioSource>();
        player_ps= player.GetComponent<ParticleSystem>();
        block_ps=GetComponent<ParticleSystem>();
    }
    void OnMouseDown()
    {
        StartCoroutine(switch_pos());
    }
    private IEnumerator switch_pos()
    {
        // switch position with player
        player_anim.Play("flash_start");
        block_anim.Play("flash_start");
        player_audio.Play();
        player_ps.Play();
        block_ps.Play();
        yield return new WaitForSeconds(0.1f);
        Vector3 temp_pos = player.transform.position;
        player.transform.position = transform.position;
        transform.position = temp_pos;
        player_anim.Play("flash_end");
        block_anim.Play("flash_end");
        yield return new WaitForSeconds(0.1f);
        

    }
}
