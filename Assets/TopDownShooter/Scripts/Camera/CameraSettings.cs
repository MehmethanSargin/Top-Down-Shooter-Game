using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Camera
{
    [CreateAssetMenu(menuName ="TopDownShooter/Camera/Camera Settings")]
    public class CameraSettings : ScriptableObject
    {
        [Header("Rotation")]
        [SerializeField] 
        private float rotationLerpSpeed = 1;
        public float RotationLerpSpeed { get { return rotationLerpSpeed;} }

        [Header("Position")]
        [SerializeField] 
        private Vector3 positionOffset;
        public Vector3 PositionOffset { get {  return positionOffset;} }

        [SerializeField] 
        private float positionLerp = 1;
        public float PositionLerp  { get { return positionLerp;} }
    }
}

