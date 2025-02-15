using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public bool isFacingRight=false;
    public float maxSpeed=3f;
    public int damage=6;
    public AudioClip hit1;
    public AudioClip hit2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Flip(){
        isFacingRight=!isFacingRight;
        transform.localScale=new Vector3(-(transform.localScale.x),transform.localScale.y,transform.localScale.z);
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="Player"){
            AudioManager.instance.RandomizeSfx(hit1,hit2);
            FindObjectOfType<PlayerStats>().TakeDamage(damage);

        }
    }
}
