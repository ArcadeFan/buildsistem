using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteHouse : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Transform _world;

    private void Start()
    {
        _button.onClick.AddListener(Delete);
    }

    private void Delete()
    {
        foreach (Transform child in _world)
        {
            Destroy(child.gameObject);
        }
    }
}
