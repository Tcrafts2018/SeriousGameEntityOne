using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public GameObject overweightAnimalBox;
    public GameObject normalWeightAnimalBox;
    public GameObject underweightAnimalBox;
    public GameObject spawnLoc;
    public Text scoreText;
    public Text timerText;
    public Text gameDone;
    int random;
    public int score;
    public float timer = 60;
    public bool cantSpawn = false;
    bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        overweightAnimalBox = Resources.Load("Prefabs/Overweight Animal Box") as GameObject;
        normalWeightAnimalBox = Resources.Load("Prefabs/Normal Weight Animal Box") as GameObject;
        underweightAnimalBox = Resources.Load("Prefabs/Underweight Animal Box") as GameObject;
        gameDone.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.text = Mathf.Round(timer).ToString();
        }
        else
        {
            gameDone.enabled = true;
            gameOver = true;
        }
        scoreText.text = score.ToString();
        random = Random.Range(1, 4);
        if (cantSpawn == false && gameOver == false)
        {
            Debug.Log("Hi");
            switch (random)
            {
                case 1:
                    Instantiate(overweightAnimalBox, spawnLoc.transform.position, spawnLoc.transform.rotation);
                    break;
                case 2:
                    Instantiate(normalWeightAnimalBox, spawnLoc.transform.position, spawnLoc.transform.rotation);
                    break;
                case 3:
                    Instantiate(underweightAnimalBox, spawnLoc.transform.position, spawnLoc.transform.rotation);
                    break;
            }
            cantSpawn = true;
        }
    }


}
