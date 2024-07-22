//defines a custom editor in Unity for the AbstractDdefines an abstract class for dungeon generation in Unity, providing a method to clear and generate a dungeon using a specified procedural generation algorithmungeonGenerator class, adding a button to the inspector that allows the user to generate a dungeon with a single click
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractDungeonGenerator : MonoBehaviour
{
    [SerializeField]
    protected TilemapVisualizer tilemapVisualizer = null;
    [SerializeField]
    protected Vector2Int startPosition = Vector2Int.zero;

    public void GenerateDungeon()
    {
        tilemapVisualizer.Clear();
        RunProdecutalGeneration();
    }

    protected abstract void RunProdecutalGeneration(); //generate our tilemaps according algoritgm
}
