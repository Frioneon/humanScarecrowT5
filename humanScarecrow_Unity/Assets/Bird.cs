using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bird : MonoBehaviour
{
    public Vector3 velocity = new Vector3(0.0f, 0.0f, 0.0f);
    public Sprite[] spriteArray = {};
    SpriteRenderer spriteRenderer;
    bool flap = false;
    bool scared = false;
    int flaptime = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        transform.position += velocity;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (( transform.position.x >  10 ) || ( transform.position.x < -10 ) || ( transform.position.y >  10 ) || ( transform.position.y < -10 ))
        {
            Destroy(this.gameObject);
        }
        if (scared)
        {
            transform.position -= velocity;
        }
        if (flaptime == 50){
            flaptime = 0;
            flap = !flap;
        }

        transform.position += velocity;
        flaptime++;
        Render();
        //when it collides with plant or scare, get scared and fly at a 45 degree difference
        //when it gets to 0,0 game over
    }

    void Render()
    {
        if (Math.Abs(velocity.x)<=velocity.y){
            if (flap){
                spriteRenderer.sprite = spriteArray[0]; 
            } else {
                spriteRenderer.sprite = spriteArray[1]; 
            }
        } else if (Math.Abs(velocity.x)<=-velocity.y){
            if (flap){
                spriteRenderer.sprite = spriteArray[2]; 
            } else {
                spriteRenderer.sprite = spriteArray[3]; 
            }
        } else if (velocity.x>=Math.Abs(velocity.y)){
            if (flap){
                spriteRenderer.sprite = spriteArray[4]; 
            } else {
                spriteRenderer.sprite = spriteArray[5]; 
            }
        } else {
            if (flap){
                spriteRenderer.sprite = spriteArray[6]; 
            } else {
                spriteRenderer.sprite = spriteArray[7]; 
            }
        }
    }
}
