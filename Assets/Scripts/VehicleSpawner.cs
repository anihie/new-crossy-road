using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{

    [SerializeField] private GameObject vehicle;
    [SerializeField] private Transform spawnPos;
    [SerializeField] private float minSeparationTime;
    [SerializeField] private float maxSeparationTime;

    private void Start()
    {
        StartCoroutine(SpawnVehicle());

    }



    private IEnumerator SpawnVehicle()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minSeparationTime, maxSeparationTime));
            GameObject go = Instantiate(vehicle, spawnPos.position, Quaternion.identity);
            go.transform.Rotate(Quaternion.Euler(0, spawnPos.rotation, 0));
        }
    }
        


}
