using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxmove : MonoBehaviour
{
    [SerializeField] private float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed*Time.deltaTime);

        if(transform.position.y <= -10f)
        {
            transform.position = Vector3.zero;
        }
    }
}
