using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeView : MonoBehaviour
{
    private float _ry = 0;

    public void SetColor(Color color)
    {
        GetComponent<MeshRenderer>().material.color = color;
    }

    public void Rotate(float speed)
    {
        transform.localRotation = Quaternion.Euler(0, _ry, 0);
        _ry += Time.unscaledDeltaTime * speed;
    }
}
