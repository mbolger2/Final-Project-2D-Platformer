using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawning : MonoBehaviour
{
    [Header("Level Prefabs")]
    public Transform levelPrefab1;
    public Transform levelPrefab2;
    public Transform levelPrefab3;
    public Transform levelPrefab4;
    public Transform levelPrefab5;

    // The current front piece
    public Transform currentLevel;

    // The position of the player
    public Transform playerPrefab;

    // The list that holds the level prefabs
    // so that we can randomly spawn level
    // prefabs when the player reaches a certain
    // y height
    public List<Transform> levels = new List<Transform>();
    
    // Update is called once per frame
    void Update()
    {
        if (playerPrefab.position.y >= 3)
        {
            // The next level
            Transform nextLevel = levels[Random.Range(0, levels.Count - 1)];

            Instantiate(nextLevel);
        }
    }
}
