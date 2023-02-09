using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tortilla : MonoBehaviour
{
    //public float mcqueen = gameObject.transform.position.x;
    // Start is called before the first frame update
    public Transform transform;
    void Start()
    {
        int moveX = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3(1.0f, 0.0f, 0.0f);
        //position+=new Vector3(0.1f, 0.0f, 0.0f);
       // this.gameObject.transform.position.y
        
    }
}
