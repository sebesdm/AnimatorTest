using UnityEngine;

public class SetupAnimatorsOnModels : MonoBehaviour
{
    public RuntimeAnimatorController controller;
    public Avatar avatar;

    void Awake()
    {
        int i = 1;

        var characters = GameObject.FindObjectsOfType<Character>();
        foreach (var character in characters)
        {
            Animator animator = character.gameObject.AddComponent<Animator>();
            animator.runtimeAnimatorController = controller;
            animator.avatar = avatar;

            if (i == 1)
            {
                i++;
                animator.SetBool("Shoot_b", true);  // Added a run animation to the animation controller, setting this for only one model
            }
        }
    }
}
