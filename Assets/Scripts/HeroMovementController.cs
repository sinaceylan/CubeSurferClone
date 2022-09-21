using UnityEngine;

public class HeroMovementController : MonoBehaviour
{
    [SerializeField] private HeroDataTrans heroDataTrans;
    //[SerializeField] private HeroInputController heroInputController;
    [SerializeField] private float forwardMovementSpeed;
    [SerializeField] private float horizontalMovementSpeed;
    [SerializeField] private float horizantalAreaLimit;

    private float newPositionX;
    
    void FixedUpdate()
    {
        SetHeroForwordMovement();
        SetHeroHorizontalMovement();
    }

    private void SetHeroForwordMovement()
    {
        transform.Translate(Vector3.down * forwardMovementSpeed * Time.fixedDeltaTime);
    }

    private void SetHeroHorizontalMovement()
    {
        //heroInputController.HorizontalValue
        newPositionX = transform.position.x + heroDataTrans.GetHeroHorizontalValue() * horizontalMovementSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX,-horizantalAreaLimit,horizantalAreaLimit);
        transform.position = new Vector3(newPositionX,transform.position.y,transform.position.z);
    }
}
