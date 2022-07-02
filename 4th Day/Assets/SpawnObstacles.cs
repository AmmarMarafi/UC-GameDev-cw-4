using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;

    // Start is called before the first frame update
    void spawn()
    {
        int newPosition = Random.Range(-1, 2);
        Vector3 vPosition = transform.position;
        vPosition.x = vPosition.x + (5 * newPosition);

        //GameObject newSpawn = Instantiate(obstacle, vPosition, Quaternion.identity);
        GameObject newSpawn = Instantiate(obstacle);
        newSpawn.transform.position = vPosition;

    }

    void Start()
    {
        InvokeRepeating("spawn", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
