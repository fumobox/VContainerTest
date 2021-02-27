using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CubeDemo
{
    public class UIView : MonoBehaviour
    {
        [SerializeField] private Button _button;

        public event Action OnClick;

        private void Start()
        {
            _button.onClick.AddListener(() =>
            {
                OnClick?.Invoke();
            });
        }
    }
}
