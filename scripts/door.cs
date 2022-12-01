using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    [SerializeField] private Sprite door_open;
    [SerializeField] private Sprite door_close;
    private SpriteRenderer spriteR;
    private bool touch_door = false;
    void Awake()
    {
        spriteR = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (touch_door && Input.GetKeyDown("w"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); ;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            spriteR.sprite = door_open;
            touch_door = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            spriteR.sprite = door_close;
            touch_door=false;
        }     
    }
}
