using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPipes : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float height;
    [SerializeField] private float maxTime;
    private float timer = 0f;

    ObjectPooler objectPooler;
    void Start()
    {
        objectPooler = ObjectPooler.Instance;
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
        ObjectPooler.Instance.SpawnFromPool("Pipe", transform.position + new Vector3(0, Random.Range(-height, height), 0), Quaternion.identity);
        timer = 0;
    }

}
