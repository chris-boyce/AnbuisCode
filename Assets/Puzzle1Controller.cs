using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1Controller : MonoBehaviour
{
    public delegate void Puzzle1Complete();
    public static event Puzzle1Complete OnPuzzleComplete;

    void PuzzleCompleted()
    {
        OnPuzzleComplete?.Invoke();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PuzzleCompleted();
        }
    }
}
