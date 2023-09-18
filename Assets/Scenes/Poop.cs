using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : MonoBehaviour
{
    public Material mat;
    // Update is called once per frame
    void Update()
    {
        mat.color = Color.Lerp(Color.red, Color.blue, Mathf.PingPong(Time.time, 1));
    }
}
