﻿using TimeWarp.Components;
using Leopotam.Ecs;
using UnityEngine;

namespace TimeWarp.Systems
{
    [EcsInject]
    public class InitializePlayerSystem : IEcsInitSystem
    {
        EcsWorld world = null;

        public void Initialize()
        {
            var playerGo = GameObject.Find("Player");
            var playerComponent = new Player();
            var player = world.CreateEntityWith(out playerComponent);
            playerComponent.gameObject = playerGo;
            playerComponent.transform = playerGo.transform;
            world.AddComponent<Dynamic>(player).rigidbody = playerGo.GetComponent<Rigidbody2D>();
            world.GetComponent<Dynamic>(player).collider = playerGo.GetComponent<CircleCollider2D>();
            var recordable = world.AddComponent<Recordable>(player);
            recordable.positions = new Vector2[300];
            recordable.velocities = new Vector2[300];
            world.AddComponent<Controllable>(player);
        }

        public void Destroy()
        {
        }
    }
}
