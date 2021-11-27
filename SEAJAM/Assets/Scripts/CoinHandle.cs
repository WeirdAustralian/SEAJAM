using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinHandle : MonoBehaviour
{
    /// <summary>
    /// DONT USE FOR ANYTHING ELSE
    /// DONT USE FOR ANYTHING ELSE
    /// DONT USE FOR ANYTHING ELSE
    /// </summary>
    
    [SerializeField] private TextMeshProUGUI coinsText;
    public int CoinCount = 0;

    public FishSpawnHandle fsh;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CoinAdd(GameObject go)
    {
        CoinCount++;
        coinsText.text = "COINS:" + CoinCount.ToString("0");
        //fsh.AllTrash.Remove(go); 
    }
}
