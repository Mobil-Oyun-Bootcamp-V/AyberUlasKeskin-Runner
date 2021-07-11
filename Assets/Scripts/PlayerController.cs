using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 [SerializeField] private float _speed;
 [SerializeField] private FloatingJoystick _joystick;
 private Rigidbody _rigidbody;

 private void Awake()
 {
  _rigidbody = GetComponent<Rigidbody>();
 }

 private void FixedUpdate()
 {
  Vector3 direction = Vector3.forward * _joystick.Vertical + Vector3.right * _joystick.Horizontal;
  _rigidbody.velocity=direction*(  _speed * Time.fixedDeltaTime);
 }
}
