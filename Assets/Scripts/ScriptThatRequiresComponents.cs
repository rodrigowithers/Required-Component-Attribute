using RequiredFieldAttribute;
using UnityEngine;

public class ScriptThatRequiresComponents : MonoBehaviour
{
    [RequiredField] public Rigidbody RequiredRigidbody;
    [RequiredField(FieldColor.Green)] public Transform RequiredTransform;
}