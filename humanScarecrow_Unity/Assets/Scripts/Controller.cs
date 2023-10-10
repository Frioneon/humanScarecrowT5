using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public List<Transform> birds = new List<Transform>(){};
    public List<Transform> plants = new List<Transform>(){};
    public List<Transform> spawners = new List<Transform>(){};
    public bool itsTime = false;
    public bool superHot = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        birds.RemoveAll(i => i == null);
        plants.RemoveAll(ii => ii == null);
        spawners.RemoveAll(iii => iii == null);
        if (itsTime == true && superHot) {
            itsTime = false;
            foreach (Transform bird in birds)
            {
                bird.gameObject.GetComponent<Bird>().TimeStep();
            }
            foreach (Transform plant in plants)
            {
                plant.gameObject.GetComponent<plant>().TimeStep();
            }
            foreach (Transform spawner in spawners)
            {
                spawner.gameObject.GetComponent<Spawner>().TimeStep();
            }
        }
        if (!superHot) {
            foreach (Transform bird in birds)
            {
                bird.gameObject.GetComponent<Bird>().TimeStep();
            }
            foreach (Transform plant in plants)
            {
                plant.gameObject.GetComponent<plant>().healCoolMax*=15;
                plant.gameObject.GetComponent<plant>().TimeStep();
            }
            foreach (Transform spawner in spawners)
            {
                spawner.gameObject.GetComponent<Spawner>().TimeStep();
            }
        }
    }
}
