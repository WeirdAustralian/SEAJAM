using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class FishSpawnHandle : MonoBehaviour
{

    [SerializeField] private List<GameObject> Trash;
    [SerializeField] private GameObject TrashToSpawn = null;
    
    [SerializeField] private Transform MinSpawnHeight;
    [SerializeField] private Transform MaxSpawnHeight;
    // Start is called before the first frame update
    void Start()
    {
        ChoseRandom();
    }   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChoseRandom();
            Instantiate(TrashToSpawn, new Vector3(-9f, Random.Range(MinSpawnHeight.position.y, MaxSpawnHeight.position.y), 0), quaternion.identity);
        }
    }

    void ChoseRandom()
    {
        int index = Random.Range(0, Trash.Count);
        Debug.Log(Trash[index].name);
        TrashToSpawn = Trash[index];
    }
}
