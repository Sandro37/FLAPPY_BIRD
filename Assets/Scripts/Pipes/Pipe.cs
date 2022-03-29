using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private float speed = 2;

    public void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;
    }


}
