using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Zombie Data", menuName = "Create Zombie Data")]
public class ZombieData : ScriptableObject {
     
    [Header("Movement Configuration")]

    [Tooltip("The movement velocity is between 0.25 and 10")]
    [SerializeField] [Range(0.25f, 10f)] public float speed = 2f;

}