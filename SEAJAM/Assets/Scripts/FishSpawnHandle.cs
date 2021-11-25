using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawnHandle : MonoBehaviour
{

    [SerializeField] private List<GameObject> Trash;
    [SerializeField] private GameObject TrashToSpawn = null;
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
        }
    }

    void ChoseRandom()
    {
        int index = Random.Range(0, Trash.Count);
        Debug.Log(Trash[index].name);
        TrashToSpawn = Trash[index];
    }
}
