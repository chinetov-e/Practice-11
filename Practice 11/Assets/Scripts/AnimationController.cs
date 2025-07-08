using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator anim;
    public void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void TriggerNext()
    {
        int random = Random.Range(1, 4);
        anim.SetInteger("NextState", random);
        Debug.Log("NextState");
    }
}