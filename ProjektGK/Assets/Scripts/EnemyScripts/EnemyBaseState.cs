﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// author: Paweł Salicki

public abstract class EnemyBaseState
{
    protected EnemyBaseState(GameObject gameObject)
    {
        this.gameObject = gameObject;
        this.transform = gameObject.transform;
    }

    protected GameObject gameObject;
    protected Transform transform;

    public abstract Type StatePerform();
}
