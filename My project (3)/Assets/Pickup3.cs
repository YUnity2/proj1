using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup3 : MonoBehaviour
{
    // Start is called before the first frame update
        public int coin_value=10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="Player"){
            FindObjectOfType<PlayerController>().totalcoin+=coin_value;
            Destroy(this.gameObject);
        }
    }
}
