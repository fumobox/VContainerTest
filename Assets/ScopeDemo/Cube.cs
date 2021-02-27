using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;


namespace ScopeDemo
{
    public class Cube : MonoBehaviour
    {

        [Inject]
        public void Construct(RootSingleton root)
        {
            Debug.Log("Cube.Construct()");
            root.Hello();
        }

    }
}

