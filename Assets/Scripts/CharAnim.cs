using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnim : MonoBehaviour
{
    public Animator animator;
    public PlayerMove playerMove;
    bool walking;
    bool running;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > .1 ||
        Input.GetAxis("Horizontal") < -.1 ||
        Input.GetAxis("Vertical") > .1 ||
        Input.GetAxis("Vertical") < -.1)
        {
            Run(false);
            Walk(true);
        }
        else
        {
            Walk(false);
        }
        
        if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            if (Input.GetAxis("Horizontal") > .1 ||
                Input.GetAxis("Horizontal") < -.1 ||
                Input.GetAxis("Vertical") > .1 ||
                Input.GetAxis("Vertical") < -.1)
            {
                Walk(false);
                Run(true);
            }
        }
        else
        {
            Run(false);
        }
    }
    public void Walk(bool walk)
    {
        if(!running)
        {
            animator.SetBool("isWalking", walk);
            playerMove.force = 0.1f;
        }
        walking = walk;
    }
    public void Run(bool run)
    {
        if(!walking)
        {
            animator.SetBool("isRunning", run);
            playerMove.force = 0.5f;
        }
        running = run;
    }
}
