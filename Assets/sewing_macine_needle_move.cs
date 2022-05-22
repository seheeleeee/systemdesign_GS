using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sewing_macine_needle_move : MonoBehaviour
{
    Vector3 pos;
    public bool is_user;
    //public float needle_speed;
    int a = 1;
    public float speed;
    public float delta;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_user)
        {
            Vector3 v = pos;
            v.y += delta * Mathf.Sin(Time.time * speed);
            transform.position = v;
        }
        
    }

}
