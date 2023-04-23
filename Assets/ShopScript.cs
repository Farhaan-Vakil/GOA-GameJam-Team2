using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour
{

        public GameObject ShopButton;
        private bool active = false;

        // Start is called before the first frame update
        void Start()
        {
            ShopButton.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void clicked()
        {
            active ^= true;
            ShopButton.SetActive(active);
        }
    }
