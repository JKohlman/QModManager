﻿namespace SMLHelper.V2.Assets
{
    using Handlers;
    using UnityEngine;

    /// <summary>
    /// "A wrapper class that uses <see cref="FishHandler"/> and <see cref="FishPrefab"/> to quickly create a custom fish
    /// </summary>
    public class Fish
    {
        /// <summary>
        /// The id to use to create the creature. This should be unique
        /// </summary>
        public string id;
        /// <summary>
        /// The display name for your fish. This is shown in the inventory, and can be whatever you want
        /// </summary>
        public string displayName;
        /// <summary>
        /// The short description of your fish in the inventory
        /// </summary>
        public string tooltip = "";
        /// <summary>
        /// The file name of your fish's sprite in the inventory. You can leave this null if your fish isn't pickupable. The file is relative
        /// from the QMods folder, e.g. "MinecraftFish/Assets/cod.png"
        /// </summary>
        public string spriteFileName;

        /// <summary>
        /// The model to use to create the creature. This would ideally only have renderer/collider components attached, but will still work if it has behaviours
        /// </summary>
        public GameObject modelPrefab;

        /// <summary>
        /// Determines whether your creature can be picked up by the player
        /// </summary>
        public bool isPickupable;
        /// <summary>
        /// Determines whether the creature moves on land or in water. Default true, which is in water. Land creature AI does not work ATM.
        /// </summary>
        public bool isWaterCreature = true;

        /// <summary>
        /// The speed at which your creature will swim
        /// </summary>
        public float swimSpeed;

        /// <summary>
        /// The interval (in seconds) between when your fish will find a new position to swim to
        /// </summary>
        public float swimInterval = 1f;

        /// <summary>
        /// The area in which your creature will look for a random position when swimming. This should be larger for larger creatures
        /// </summary>
        public Vector3 swimRadius;
    }
}