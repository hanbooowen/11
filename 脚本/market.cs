using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class market : MonoBehaviour
{

    public int marketnum = 1;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Canvas/marketmenu/marketnum").GetComponent<Text>().text = "你拥有" + marketnum + "个市场";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
