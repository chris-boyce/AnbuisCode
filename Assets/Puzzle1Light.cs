using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1Light : MonoBehaviour
{
    public Light Light;
    public float transitionDuration = 1.5f;
    public bool hasTransitioned = true;
    private bool Change;

    public float LerpValue;
    void Start()
    {
        Light.color = Color.red;
    }
    void OnEnable()
    {
        Puzzle1Controller.OnPuzzleComplete += ChangeColor;
    }

    void OnDisable()
    {
        Puzzle1Controller.OnPuzzleComplete -= ChangeColor;
    }

    void ChangeColor()
    {
        hasTransitioned = false;
    }

    void FixedUpdate()
    {
        if (!hasTransitioned)
        {
            LerpValue += 0.01f * (1f / transitionDuration);
            Color lerpedColor = Color.Lerp(Color.red, Color.green, LerpValue);

            Light.color = lerpedColor;

            if (LerpValue >= 1f)
            {
                Destroy(this);
            }
        }

    }

}
