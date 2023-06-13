using UnityEngine;

public static class Converter
{
    public static Vector2 Vector3ToVector2InXZ(Vector3 vector)
    {
        return new Vector2(vector.x, vector.z);
    }
}
