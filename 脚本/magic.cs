using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class magic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Canvas/magicmenu/magicnum").GetComponent<Text>().text = "���֪ʶ�ȼ�Ϊ"+"����ѧϰ"+"��ħ��";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
