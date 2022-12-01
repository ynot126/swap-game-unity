using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title_background : MonoBehaviour
{
    [Header("Background Settings")]
    [Range(-2f, 2f)][SerializeField] public float scrollspeed = 0.5f;
    private float offset;
    private Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;

    }
    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime * scrollspeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
