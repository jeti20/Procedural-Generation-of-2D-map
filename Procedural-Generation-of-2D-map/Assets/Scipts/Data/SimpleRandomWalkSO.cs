//defines a ScriptableObject for storing parameters used in a simple random walk dungeon generation algorithm, such as the number of iterations, walk length, and whether to start randomly each iteration.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SimpleRandom WalkParameters_",menuName = "PCG/SimpleRandomWalkData")]
public class SimpleRandomWalkSO : ScriptableObject
{
    public int iterations = 10, walkLength = 10;
    public bool starRandomEachIteration = true;
    internal bool startRandomlyEachIteration;
}
