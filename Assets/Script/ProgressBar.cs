using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Image _background;

    [SerializeField] private Image _value;


    public void Awake()
    {
        SetProgress(0.5f);
    }

    public void SetProgress(float progress)
    {
        progress = Mathf.Clamp01(progress);
        var backgroundSize = _background.rectTransform.sizeDelta.x;
        var fillingSize = progress * backgroundSize;
        _value.rectTransform.sizeDelta = new Vector2(fillingSize, _background.rectTransform.sizeDelta.y);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
