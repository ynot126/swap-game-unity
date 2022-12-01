using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] private float horizal_speed;
    [SerializeField] private float vertical_speed;
    [SerializeField] private float flash_distance;
    private bool face_right=true;
    private Animator anim;
    public bool move = true;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey("a") && Input.GetKey("d"))
        {
        }
        else if (Input.GetKey("a") && move == true)
        {
            transform.Translate(-1 * horizal_speed * Time.deltaTime, 0, 0);
            face_right = false;
        }
        else if (Input.GetKey("d") && move == true)
        {
            transform.Translate(1 * horizal_speed * Time.deltaTime, 0, 0);
            face_right = true;
        }
    }
    void LateUpdate()
    {
        if (face_right)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (!face_right)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
