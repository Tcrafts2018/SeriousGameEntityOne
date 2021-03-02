using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    bool canPickUp;
    bool makeChild;
    GameObject Player;
    float y = -270;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Player.transform.eulerAngles = new Vector3(0, y, 0);
        if (Input.GetKeyDown("d"))
        {
            y = y + 90;
        }
        if (Input.GetKeyDown("a"))
        {
            y = y - 90;
        }
        if (canPickUp == true)
        {
            if (Input.GetKeyDown("e"))
            {
                Debug.Log("Hello");
                makeChild = true;
            }
        }
    }

    /*private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Pick Up Trigger")
        {
            canPickUp = true;
            if (makeChild == true)
            {
                other.transform.parent.parent = Player.transform;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Pick Up Trigger")
        {
            canPickUp = false;
        }
    }*/
}
