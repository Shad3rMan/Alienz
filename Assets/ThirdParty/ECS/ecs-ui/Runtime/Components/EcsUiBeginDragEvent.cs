// ----------------------------------------------------------------------------
// The MIT License
// Ui extension https://github.com/Leopotam/ecs-ui
// for ECS framework https://github.com/Leopotam/ecs
// Copyright (c) 2018 Leopotam <leopotam@gmail.com>
// ----------------------------------------------------------------------------

using UnityEngine;

namespace LeopotamGroup.Ecs.Ui.Components {
    public sealed class EcsUiBeginDragEvent {
        public string WidgetName;

        public GameObject Sender;

        public Vector2 Position;

        public int PointerId;
    }
}