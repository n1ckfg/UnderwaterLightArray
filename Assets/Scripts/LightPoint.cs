﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPoint {

    public Vector3 position;
    public Color color;
    public int oscIndex;
    public int vertIndex;

    public LightPoint(Vector3 _position, Color _color, int _oscIndex, int _vertIndex) {
        position = _position;
        color = _color;
        oscIndex = _oscIndex;
        vertIndex = _vertIndex;
    }

}