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
        GameObject.Find("Canvas/marketmenu/marketnum").GetComponent<Text>().text = "��ӵ��" + marketnum + "���г�";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
