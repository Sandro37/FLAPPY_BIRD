using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPipes : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float height;
    [SerializeField] private float maxTime;
    private float timer = 0f;

    void Start()
    {
        CreatePipe();
    }
    void Update()
    {
        if(timer > maxTime)
        {
            CreatePipe();
        }
        timer += Time.deltaTime;
    }
    private void CreatePipe()
    {
        GameObject newPipe = Instantiate(pipePrefab);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipe, 10f);
        timer = 0;
    }

}
