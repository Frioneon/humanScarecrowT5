// PlayerMove.cs
    using UnityEngine;
    using System.Collections;
    using System.Collections.Generic; 
    using UnityEngine.UI;


    public class PlayerMove : MonoBehaviour {
        private Camera cam;
        public Sprite[] spriteList;
        SpriteRenderer spriteRenderer; 

        void Start () {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        }

        void Update() {
            if (Input.GetKey("up")||Input.GetKey("w")) {
                spriteRenderer.sprite = spriteList[3];
            }
            if (Input.GetKey("down")||Input.GetKey("s")) {
                spriteRenderer.sprite = spriteList[0];
            }
            if (Input.GetKey("right")||Input.GetKey("d")) {
                spriteRenderer.sprite = spriteList[2];
            }
            if (Input.GetKey("left")||Input.GetKey("a")) {
                spriteRenderer.sprite = spriteList[1];
            }
        }

    }