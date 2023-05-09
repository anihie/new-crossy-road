using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{

    [SerializeField] private GameObject vehicle;
    [SerializeField] private Transform spawnPos;
    [SerializeField] private Transform carHolder;
    [SerializeField] private float minSeparationTime;
    [SerializeField] private float maxSeparationTime;
    [SerializeField] private bool isRightSide;

    private List<GameObject> currentCars = new List<GameObject>();

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
            
            if(!isRightSide)
            {
                go.transform.Rotate(new Vector3 (0, 360, 0));
            }
        }

        for (int i = 0; i < terrainInSuccession; i++)
            {
                GameObject car = Instantiate(carHolder);
                currentCars.Add(car);
            }
    }
        


}
