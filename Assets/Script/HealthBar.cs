using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    public ProgressBar _progressBar;
    
    [SerializeField]
    public HealthBehaviour _healthBehaviour;

    private RectTransform _rectTransform;

    private void Awake()
    {
        _rectTransform = transform as RectTransform;
    }

    private void Update()
    {
        UpdateProgressBarPosition(_healthBehaviour.transform);
        UpdateProgressBarValue(_healthBehaviour);
    }

    private void UpdateProgressBarPosition(Transform followingObject)
    {
        var worldPosition = followingObject.transform.position;
        var screenPoint = Camera.main.WorldToScreenPoint
            (worldPosition);

        var healthBarParent = transform.parent as RectTransform;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(healthBarParent, screenPoint, null,
            out var localPoint);
        _rectTransform.anchoredPosition = localPoint;
    }

    private void UpdateProgressBarValue(HealthBehaviour healthBehaviour)
    {
        _progressBar.SetProgress((healthBehaviour.Health/ 
                                  (float)healthBehaviour.MaxHealth));
    }
}
