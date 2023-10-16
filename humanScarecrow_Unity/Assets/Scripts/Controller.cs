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

    }
}
