using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour
{
    public Vector3 Startpos = new Vector3 (0,0,0);
   
    void Start()
    {
        Startpos = gameObject.transform.position;
    }
    public void reset()
    {
        gameObject.transform.position = Startpos;
    }
   
}
