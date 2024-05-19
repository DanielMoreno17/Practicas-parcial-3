using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnn : MonoBehaviour
{

    [SerializeField]
    GameObject spawn_point;
    [SerializeField] float altura;
   


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float y = transform.position.y;
        if (y < altura)
        {
            transform.position = spawn_point.transform.position;
      

        }
    }
}
