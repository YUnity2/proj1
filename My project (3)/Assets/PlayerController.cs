using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    public KeyCode Spacebar;
    public KeyCode L;
    public KeyCode R;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    private Animator anim; 
    public KeyCode Return;
    public Transform firepoint;
    public GameObject bullet;
    public AudioClip jump1;
    public AudioClip jump2;
    public int totalcoin=0;
    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(Spacebar) && grounded){
            Jump();
        }
        if(Input.GetKey(L)){
            GetComponent<Rigidbody2D>().velocity=new Vector2(-moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
            if(GetComponent<SpriteRenderer>()!=null){
                GetComponent<SpriteRenderer>().flipX=true;
            }
        }
        if(Input.GetKey(R)){
            GetComponent<Rigidbody2D>().velocity=new Vector2(moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
            if(GetComponent<SpriteRenderer>()!=null){
                GetComponent<SpriteRenderer>().flipX=false;
            }
        }
        if(Input.GetKeyDown(Return)){
            Shoot();
        }
        if(!PauseResume.paused){
            if(Input.GetKeyDown(Spacebar)&& grounded){
                Jump();
            }
        }
        anim.SetFloat("Speed",Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        anim.SetBool("grounded", grounded);
    }
    void Jump(){
        GetComponent<Rigidbody2D>().velocity=new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
        AudioManager.instance.RandomizeSfx(jump1,jump2);
    }
    void FixedUpdate(){
        grounded=Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,whatIsGround);
    }
    public void Shoot(){
        Instantiate(bullet,firepoint.position,firepoint.rotation);
    }
}