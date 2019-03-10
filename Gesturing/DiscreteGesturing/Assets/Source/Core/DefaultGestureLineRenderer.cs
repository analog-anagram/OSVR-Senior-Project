﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gestures {
    public class DefaultGestureLineRenderer : MonoBehaviour {
        public Color startColor = new Color(.266f, .333f, .533f, .5f);
        public Color endColor = new Color(.8f, .866f, 1, .5f);
        public float widthMultiplier = 0.01f;
        public LineRenderer lineRenderer;
        private Gradient gradient;

        void Awake() {
            lineRenderer = gameObject.AddComponent<LineRenderer>();
            lineRenderer.widthMultiplier = widthMultiplier;
            lineRenderer.positionCount = 0;
            lineRenderer.material = new Material(Shader.Find("Sprites/Default"));

            gradient = new Gradient();
            gradient.SetKeys(
                new GradientColorKey[] { new GradientColorKey(startColor, 0.0f), new GradientColorKey(endColor, 1.0f) },
                new GradientAlphaKey[] { new GradientAlphaKey(startColor.a, 0.0f), new GradientAlphaKey(endColor.a, 1.0f) }
                );
            lineRenderer.colorGradient = gradient;
        }

        void OnValidate() {
            gradient.SetKeys(
                new GradientColorKey[] { new GradientColorKey(startColor, 0.0f), new GradientColorKey(endColor, 1.0f) },
                new GradientAlphaKey[] { new GradientAlphaKey(startColor.a, 0.0f), new GradientAlphaKey(endColor.a, 1.0f) }
            );
            lineRenderer.colorGradient = gradient;
            lineRenderer.widthMultiplier = widthMultiplier;
        }
    }
}