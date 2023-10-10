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
    public AudioClip caw;
    public AudioClip laugh;
    public AudioClip bonk;
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
        if (( transform.position.x >  7 ) || ( transform.position.x < -7 ) || ( transform.position.y >  4 ) || ( transform.position.y < -4 ))
        {
            Destroy(this.gameObject);
            if (!scared) {
                audioSource.PlayOneShot(laugh, 0.7F);
            }
        }
        if (scared)
        {
            transform.position += velocity;
            transform.position += velocity;
            transform.position += velocity;
            flap = !flap;
        }
        Render();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Scarecrow") {
            if (flap) {
                velocity = new Vector3(-0.4f*velocity.x - 0.12f*velocity.y, 0.12f*velocity.x + 0.4f*velocity.y);
            } else {
                velocity = new Vector3(-0.4f*velocity.x + 0.12f*velocity.y, -0.12f*velocity.x + 0.4f*velocity.y);
            }
            scared = true;
            audioSource.PlayOneShot(caw, 0.4F);
        }
        else if (col.tag == "Bird") {
            if (flap) {
                velocity = new Vector3(-0.4f*velocity.x - 0.12f*velocity.y, 0.12f*velocity.x + 0.4f*velocity.y);
            } else {
                velocity = new Vector3(-0.4f*velocity.x + 0.12f*velocity.y, -0.12f*velocity.x + 0.4f*velocity.y);
            }
            scared = true;
            audioSource.PlayOneShot(bonk, 0.4F);
        }
        else if (col.tag == "Time") {
            TimeStep();
        }
    }

    public void TimeStep() {
        transform.position += velocity;
        flap = !flap;
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
