using UnityEngine;

namespace CubeDemo
{
    public class CubeModel
    {
        public Color Color { get; set; }

        public float RotationSpeed { get; set; }

        public void SetRandomColor()
        {
            Color = new Color(Random.Range(.5f, 1f), Random.Range(.5f, 1f), Random.Range(.5f, 1f), 1);
        }
    }
}