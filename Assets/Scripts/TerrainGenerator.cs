using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{

    [SerializeField] private int maxTerrainCount;
    [SerializeField] private List<TerrainData> terrainDatas = new List<TerrainData>();
    [SerializeField] private Transform terrainHolder;

    private List<GameObject> currentTerrains = new List<GameObject>();
    private Vector3 currentPosition = new Vector3(0, 0, 0);

    
    private void Start()
    {
        for (int i = 0; i < maxTerrainCount; i++)
        {
            SpawnTerrain(true);
        }
        maxTerrainCount = currentTerrains.Count;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            SpawnTerrain(false);
        }
    }

    private void SpawnTerrain(bool isStart)
    {
        int whichTerrain = Random.Range(0, terrainDatas.Count);
        int terrainInSuccession = Random.Range(1, terrainDatas[whichTerrain].maxInSuccession);

        for (int i = 0; i < terrainInSuccession; i++)
        {
            GameObject terrain = Instantiate(terrainDatas[whichTerrain].terrain, currentPosition, Quaternion.identity, terrainHolder);
            currentTerrains.Add(terrain);
            
            if (!isStart)
            {
                if (currentTerrains.Count > maxTerrainCount)
                {
                    Destroy(currentTerrains[0]);
                    currentTerrains.RemoveAt(0);
                }
            }
            
            currentPosition.x++;  
        }
            
    }      
       
}




