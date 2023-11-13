using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawning : MonoBehaviour
{
    // The current front piece
    public Transform currentLevel;

    // The position of the player
    public Transform playerPrefab;

    // The list that holds the level prefabs
    // so that we can randomly spawn level
    // prefabs when the player reaches a certain
    // y height
    public List<Transform> levels = new List<Transform>();

    // The position that the level prefab will be instantiated at
    public Vector3 nextLevel;

    // The y position the player needs to clear for a new
    // section to be spawned
    public int yCheckpoint = 4;

    Quaternion rotation = Quaternion.identity;

    private void Start()
    {
        nextLevel = new Vector3(0, 10, 0);
    }
    // Update is called once per frame
    void Update()
    {
        if (playerPrefab.position.y >= yCheckpoint)
        {
            // ASK JOSE IN CLASS
            Transform level = Instantiate(levels[Random.Range(0, levels.Count - 1)], nextLevel, rotation);

            // Increase the y level that the sections will be instantiated at
            nextLevel.y += 10;

            // Increase the y level that the player needs to clear for the next
            // section to be instantiated
            yCheckpoint += 10;
        }
    }
}
