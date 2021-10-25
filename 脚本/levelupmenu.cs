using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelupmenu : MonoBehaviour
{
    public GameObject btnyes;
    public GameObject btnno;

    public static int level = 1;

    // Start is called before the first frame update
    void Start()
    {
        btnyes.GetComponent<Button>().onClick.AddListener(Yes);
        btnno.GetComponent<Button>().onClick.AddListener(No);
    }

    // Update is called once per frame
    void Update()
    {
        switch (level)
        {
            case 1:
                GameObject.Find("Canvas/castle/levelupmenu/need").GetComponent<Text>().text = "升级城堡所需要的资源为：金币*1000、石头*10、木头*10";
                break;
            case 2:
                GameObject.Find("Canvas/castle/levelupmenu/need").GetComponent<Text>().text = "升级城堡所需要的资源为：金币*2000、石头*15、木头*15";
                break;
            case 3:
                GameObject.Find("Canvas/castle/levelupmenu/need").GetComponent<Text>().text = "城堡已经满级，无法继续提升！";
                break;
        }
    }

    void Yes()
    {
        if (level < 3)
        {
            level++;
            GameObject.Find("Canvas/levelnum").GetComponent<Text>().text = level.ToString();
        }
        this.gameObject.SetActive(false);
    }

    void No()
    {
        this.gameObject.SetActive(false);
    }
}
