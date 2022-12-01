using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_child : MonoBehaviour
{
    private gate_parent par;
    void Awake()
    {
        par = transform.parent.GetComponent<gate_parent>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player"|| col.tag=="block")
        {
            par.switch_on();
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player" || col.tag == "block")
        {
            par.switch_off();
        }
    }
}
