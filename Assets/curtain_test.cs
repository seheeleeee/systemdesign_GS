using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curtain_test : MonoBehaviour
{
    public bool is_user_see;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (is_user_see)
        {
            transform.position += new Vector3(speed * 0.02f, 0, 0);
        }
        else
        {

        }
        
    }
}