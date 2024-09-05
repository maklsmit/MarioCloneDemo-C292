using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaivor : MonoBehaviour
{

    private Vector2 startPosition;
    [SerializeField] private float moveSpeed = 3;
    [SerializeField] private float rotationSpeed = 3;
    [SerializeField] private float offset = 10;
    [SerializeField] private bool canMove;
    [SerializeField] private bool canRotate;
    private bool isMovingRight = true;
    // Start is called before the first frame update

    // private void Awake(){
        
    // }
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        LoopPlatform();
    }

    private void LoopPlatform(){
        if(canMove){
            MovePlatform();
        }

        if(canRotate){
            RotatePlatform();
        }
    }

    private void MovePlatform(){
        if(transform.position.x >= startPosition.x + offset){
            isMovingRight = false;
        }
        if(transform.position.x <= startPosition.x - offset){
            isMovingRight = true;
        }

        if(isMovingRight){
            this.transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else{
            this.transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
    }

    private void RotatePlatform(){
        this.transform.Rotate(0,0, rotationSpeed * Time.deltaTime);
    }

    // private void MovePlatformBugless(){
    //     if(transform.position.x >= startPosition.x + offset){
    //         isMovingRight = false;
    //     }
    //     if(transform.position.x <= startPosition.x - offset){
    //         isMovingRight = true;
    //     }

    //     if(isMovingRight){
    //         transform.Translate(transform.position + moveSpeed * Time.deltaTime);
    //     }
    //     else{
    //         transform.Translate(transform.position - moveSpeed * Time.deltaTime);
    //     }    
    // }
}
