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
        if (( transform.position.x >  20 ) || ( transform.position.x < -20 ) || ( transform.position.y >  20 ) || ( transform.position.y < -20 ))
        {
            Destroy(this.gameObject);
            if (!scared) {
                audioSource.PlayOneShot(laugh, 0.7F);
            }
        }
        if (scared)
        {
            transform.localScale *= 1.006f;
            flap = !flap;
        }
        Render();
        transform.position += velocity;
        flap = !flap;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Scarecrow") {
            float random = UnityEngine.Random.Range(0f, 260f);
            velocity = new Vector3(0.03f*Mathf.Cos(random), 0.03f*Mathf.Sin(random));
            scared = true;
            audioSource.PlayOneShot(caw, 0.4F);
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
