using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawning : MonoBehaviour
{
    // The position of the player
    public Transform playerPrefab;

    // The list that holds the level prefabs
    // so that we can randomly spawn level
    // prefabs when the player reaches a certain
    // y height
    public List<Transform> levels = new List<Transform>();

    // The list that holds the ending level 
    // prefabs so that when the 1:00 marker
    // is hit we pull from the list contataining 
    // the ending level prefabs and not the normal
    // level prefabs
    public List<Transform> endingLevels = new List<Transform>();

    // The list that holds the beginning level prefabs
    // so that we can randomly spawn different starts 
    // to the game levels
    public List<Transform> beginningLevels = new List<Transform>();

    // The position that the starting level prefab will be instantiated at
    public Vector3 startLevel;

    // The position that the level prefab will be instantiated at
    public Vector3 nextLevel;

    // The y position the player needs to clear for a new
    // section to be spawned
    public int yCheckpoint = 4;

    // Quaternion rotation holder so that the 
    // level prefabs spawn with no z axis rotation
    Quaternion rotation = Quaternion.identity;

    private void Start()
    {
        startLevel = new Vector3(0, 0, 0);
        Transform beginningLevel = Instantiate(beginningLevels[Random.Range(0, beginningLevels.Count - 1)],
            startLevel, rotation);

        nextLevel = new Vector3(0, 10, 0);
    }
    // Update is called once per frame
    void Update()
    {
        if (playerPrefab.position.y >= yCheckpoint)
        {
            // Spawn a new level above th player
            Transform level = Instantiate(levels[Random.Range(0, levels.Count - 1)],
                nextLevel, rotation);

            // Increase the y level that the sections will be instantiated at
            nextLevel.y += 10;

            // Increase the y level that the player needs to clear for the next
            // section to be instantiated
            yCheckpoint += 10;
        }

        //if (Mathf.FloorToInt(StopWatch.Instance.time / 60f) != 1)
        //{
            
        //}
        //else
        //{
        //    Transform endingLevel = Instantiate(endingLevels[Random.Range(0, endingLevels.Count - 1)],
        //        nextLevel, rotation);
        //}

    }
}
