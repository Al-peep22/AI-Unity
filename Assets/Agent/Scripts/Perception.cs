using UnityEngine;

public abstract class Perception : MonoBehaviour
{
    public string tagName;
    public float maxDistance;
    public float maxAngle; // FOV

    public abstract GameObject[] GetGameObjects();
}
