using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawner : MonoBehaviour
{
    public Bird birdPrefab;
    public float maxSpeed;
    public float minSpeed;
    public float speedRate;
    public float maxWait;
    public float minWait;
    public float waitRate;
    public float speedRateRate;
    public float waitRateRate;
    public GameObject pauseMenuUI;
    public Vector3 direction;
    System.Random random = new System.Random();
    public int time = 0;
    Bird bird;
    //public Controller controller;
    float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        time = random.Next(Convert.ToInt32(minWait), Convert.ToInt32(maxWait));
        time = random.Next(Convert.ToInt32(minWait), Convert.ToInt32(maxWait));
    }

    // Update is called once per frame
    void Update()
    {
        if (pauseMenuUI.activeInHierarchy == false) {
            if (time <= 0) {
                minWait*=waitRate*waitRateRate;
                maxWait*=waitRate;
                time = random.Next(Convert.ToInt32(minWait), Convert.ToInt32(maxWait));
                bird = Instantiate(birdPrefab);
                speed = random.Next(Convert.ToInt32(minSpeed), Convert.ToInt32(maxSpeed));
                minSpeed*=speedRate;
                maxSpeed*=speedRate*speedRateRate;
                bird.velocity = new Vector3(direction.x*speed/100f, direction.y*speed/100f);
                bird.gameObject.transform.position = transform.position;
            }
            time--;
        }
    }

    /*public void TimeStep(){
        if (time == 0) {
            time = random.Next(minWait, maxWait);
            bird = Instantiate(birdPrefab);
            if (!controller.superHot) {bird.velocity = direction*speed;}
            else {bird.velocity = direction;}
            bird.gameObject.transform.position = transform.position;
            time++;
            controller.birds.Add(bird.gameObject.transform);
        }
        time--;
    }*/
}
