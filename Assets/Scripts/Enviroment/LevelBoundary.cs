using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float bottomSide = 2.7f; // Κάτω όριο
    public static float topSide = 7f; // Πάνω όριο
    public float internalBottom;
    public float internalTop;

    void Update()
    {
        internalBottom = bottomSide;
        internalTop = topSide;
    }
}