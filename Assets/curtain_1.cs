using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curtain_1 : MonoBehaviour
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
            transform.Translate(0, 1 * speed * Time.deltaTime, 0);
        }
        else
        {
            
        }
    }
}
