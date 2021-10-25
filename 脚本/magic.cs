using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class magic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Canvas/magicmenu/magicnum").GetComponent<Text>().text = "你的知识等级为"+"可以学习"+"级魔法";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
