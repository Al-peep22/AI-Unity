using UnityEngine;

public abstract class Perception : MonoBehaviour
{
    [SerializeField] string info;

    [SerializeField] protected string tagName;
    [SerializeField] protected float maxDistance;
    [SerializeField, Range (0, 180)] protected float maxAngle; // FOV

    public abstract GameObject[] GetGameObjects();
}
