using UnityEngine;

public class SetupAnimatorsOnModels : MonoBehaviour
{
    public RuntimeAnimatorController controller;
    public Avatar avatar;

    void Awake()
    {
        var characters = GameObject.FindObjectsOfType<Character>();
        foreach (var character in characters)
        {
            Animator animator = character.gameObject.AddComponent<Animator>();
            animator.runtimeAnimatorController = controller;
            animator.avatar = avatar;
        }
    }
}
