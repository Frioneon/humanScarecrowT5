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
    public AudioClip caw;
    public AudioClip laugh;
    AudioSource audioSource;
    

    // Start is called before the first frame update
    void Start()
    {
        transform.position += velocity;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
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
        //when it gets to 0,0 game over
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Scarecrow") {
            if (flap) {
                velocity = new Vector3(-2f*velocity.x + 0.3f*2f*velocity.y, -0.3f*2f*velocity.x - 2f*velocity.y);
            } else {
                velocity = new Vector3(-2f*velocity.x - 0.3f*2f*velocity.y, 0.3f*2f*velocity.x - 2f*velocity.y);
            }
            audioSource.PlayOneShot(caw, 0.4F);
        }
        else if (col.tag == "Plant") {
            if (flap) {
                velocity = new Vector3(-velocity.x + 0.3f*velocity.y, -0.3f*velocity.x - velocity.y);
            } else {
                velocity = new Vector3(-velocity.x - 0.3f*velocity.y, 0.3f*velocity.x - velocity.y);
            }
            audioSource.PlayOneShot(laugh, 0.7F);
        }
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
