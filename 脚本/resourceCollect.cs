using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourceCollect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        heroControl hero = collision.GetComponent<heroControl>();
        if(hero!=null)
        {
            hero.ChangeWood(5);
            Destroy(this.gameObject);
        }
    }
}
