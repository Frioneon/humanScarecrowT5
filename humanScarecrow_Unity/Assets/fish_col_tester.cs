using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish_col_tester : MonoBehaviour
{   
    // Vector3 position;
    // Start is called before the first frame update
    void Start()
    {   
        // position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetMouseButtonDown(0))
        {   
            Debug.Log("moveeee" + transform.position);
            moveFish();
        }
    }

    void moveFish() {
        // position = position + new Vector3(-1,0,0);
        transform.position += new Vector3(-1,0,0);
    }
}
