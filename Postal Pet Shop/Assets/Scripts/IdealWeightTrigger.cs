using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdealWeightTrigger : MonoBehaviour
{
    LevelController LC;

    private void Start()
    {
        GameObject Controller = GameObject.Find("Level Controller");
        LC = Controller.GetComponent<LevelController>();
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GameObject.Find("Normal Weight Animal Box(Clone)") != null)
            {
                Destroy(GameObject.Find("Normal Weight Animal Box(Clone)"));
                LC.score++;
                LC.cantSpawn = false;
            }
            else
            {
                Destroy(GameObject.Find("Normal Weight Animal Box(Clone)"));
                LC.cantSpawn = false;
            }
        }
    }
}
