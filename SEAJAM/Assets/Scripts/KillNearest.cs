using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillNearest : MonoBehaviour
{
    [SerializeField] private Transform Reference;
    [SerializeField] private FishSpawnHandle FSH;

    public float lowestDif = 100000;
    public CoinHandle ch;
    private GameObject LowestDifgameobject;

    public List<GameObject> AllTrashCopy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            KillNear();
            Debug.Log(FSH.AllTrash[0]);
        }
    }

    
    //Grab the nearest trash and kill it.
    public void KillNear()
    {
        AllTrashCopy = FSH.AllTrash;
        for (int i=0; i<AllTrashCopy.Count; i++)
        {
            float difx = Reference.position.x - FSH.AllTrash[i].transform.position.x;
            float dify = Reference.position.y - FSH.AllTrash[i].transform.position.y;

            float TtlDif = difx + dify;

            if (TtlDif < lowestDif)
            {
                lowestDif = TtlDif;
                LowestDifgameobject = FSH.AllTrash[i];
                ch.CoinAdd(FSH.AllTrash[i]);
                
                //Debug.Log(LowestDifgameobject.name);
                //Debug.Log("ebf");
            }
            
        }

        lowestDif = 1000000;
    }
}
