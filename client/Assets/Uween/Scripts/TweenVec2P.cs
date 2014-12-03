﻿using UnityEngine;
using System.Collections;

public abstract class TweenVec2P : TweenVec2
{
    override public Vector3 vector
    {
        get
        {
            return GetTransform().localPosition;
        }
        set
        {
            GetTransform().localPosition = value;
        }
    }
}