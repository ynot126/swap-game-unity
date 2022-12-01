using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate_parent : MonoBehaviour
{
    private Transform _gate;
    private Transform _switch;
    private Transform _on;
    // Start is called before the first frame update
    void Awake()
    {
        _gate = transform.GetChild(0);
        _switch = transform.GetChild(1);
        _on = transform.GetChild(1).GetChild(0);
    }

    public void switch_on()
    {
        _on.GetComponent<SpriteRenderer>().enabled = false;
        _gate.GetComponent<BoxCollider2D>().enabled = false;
        _gate.GetComponent<Animator>().Play("gate off");
    }
    public void switch_off()
    {
        _gate.GetComponent<BoxCollider2D>().enabled = true ;
        _on.GetComponent<SpriteRenderer>().enabled = true;
        _gate.GetComponent<Animator>().Play("gate on");
    }
}
