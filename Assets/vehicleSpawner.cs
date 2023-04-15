using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicleSpawner : MonoBehaviour
{

    [SerializeField] private GameObject vehicle;
    [SerializeField] private Transform spawnPos;

    private void Start()
    {
        StartCoroutine(SpawnVehicle());

    }



    private IEnumerator SpawnVehicle()
    {
        yield return new WaitForSeconds(2);
        Instantiate(vehicle, spawnPos.position, Quaternion.identity);
    }


}
