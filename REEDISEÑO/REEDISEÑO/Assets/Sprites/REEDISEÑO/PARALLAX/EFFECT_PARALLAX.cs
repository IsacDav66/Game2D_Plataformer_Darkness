using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EFFECT_PARALLAX : MonoBehaviour
{
    [Range(1f, 20F)]
    public float ScrollSpeed = 1;
    public float ScrollOfSet;

    Vector2 StartPos;
    float NewPos;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        NewPos = Mathf.Repeat(Time.time * -ScrollSpeed, ScrollOfSet);
        transform.position = StartPos + Vector2.right * NewPos;
    }
}
