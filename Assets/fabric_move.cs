using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fabric_move : MonoBehaviour
{
    public bool is_user_see;
    public float speed;
    public float waittime;
    Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
        StartCoroutine(WaitForSeconds(waittime)) ;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_user_see)
        {
            if (transform.position.y<-150)
            {
                StartCoroutine("FadeAway");
            }
        }
        else
        {

        }
    }

    IEnumerator FadeAway()
    {
        for(float f=1f; f>=0; f -= 0.005f)
        {
            Color c = renderer.material.color;
            c.a = f;
            renderer.material.color = c;
            yield return null;
        }
    }

    IEnumerator WaitForSeconds(float time)
    {
        yield return new WaitForSeconds(time);
    }
}