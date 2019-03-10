﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gestures {
    public class SquareGesture : Gesture {
        public SquareGesture() : 

            base(new List<Check> {
                new LineCheck(new Vector3(1, 1, 0), new Vector3(-1, 1, 0)),
                new LineCheck(new Vector3(-1, 1, 0), new Vector3(-1, -1, 0)),
                new LineCheck(new Vector3(-1, -1, 0), new Vector3(1, -1, 0)),
                new LineCheck(new Vector3(1, -1, 0), new Vector3(1, 1, 0)),

                new RadiusCheck(new Vector3(1, 1, 0)),
                new RadiusCheck(new Vector3(-1, 1, 0)),
                new RadiusCheck(new Vector3(-1, -1, 0)),
                new RadiusCheck(new Vector3(1, -1, 0)),

            },
            new CompositeNormalizer(new Vector3(-1, -1, 0), new Vector3(1, 1, 0)),
            new GestureEvent())
        {

        }
    }
}