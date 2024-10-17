using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{
    public Transform[] Backgrounds;
    public float ParallaxScale;
    public float ParallaxReductionFactor;
    public float smoothing;
    private Vector3 lastPosition;
    // Start is called before the first frame update
    void Start()
    {
     lastPosition=transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        var parallax=(lastPosition.x - transform.position.x)*ParallaxScale;
        for(int i=0;i<Backgrounds.Length;i++){
            var backgroundTargetPosition=Backgrounds[i].position.x +parallax*(i*ParallaxReductionFactor+1);
            Backgrounds[i].position=Vector3.Lerp(Backgrounds[i].position,new Vector3(backgroundTargetPosition,Backgrounds[i].position.y,Backgrounds[i].position.z),smoothing*Time.deltaTime);

        }
        lastPosition=transform.position;
    }
}
