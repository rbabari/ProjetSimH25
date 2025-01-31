using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonScript : MonoBehaviour
{
    public GameObject g;
    // Start is called before the first frame update
    void Start()
    {
        g.GetComponent<Transform>().Translate(new Vector3(1,0,0));
      
    }

    // Update is called once per frame
    void Update()
    {
        g.GetComponent<Transform>().Translate(new Vector3(1, 0, 0));
    }
}
