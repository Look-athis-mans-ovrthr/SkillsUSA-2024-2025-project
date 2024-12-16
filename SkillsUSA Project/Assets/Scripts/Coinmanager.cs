using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coinmanager : MonoBehaviour
{
    public int coinCount;
    public TextMeshProUGUI coinText;
    public GameObject door; 
    private bool doorDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Gear Count: " + coinCount.ToString();

        if(coinCount == 2 && !doorDestroyed)
        {
            doorDestroyed = true;
            Destroy(door);
        }
    }
}
