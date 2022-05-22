using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curtain : MonoBehaviour
{
    public float waittime;
    Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
        StartCoroutine(WaitForSeconds(waittime));
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("fabric").GetComponent<fabric_move>().yy)
        {
            StartCoroutine("Fadein");
        }
    }

    IEnumerator Fadein()
    {
        for (float f = 0f; f <= 1f; f += 0.005f)
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
