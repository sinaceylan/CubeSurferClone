using UnityEngine;

public class HeroDataTrans : MonoBehaviour
{
    [SerializeField] private HeroInputController heroInputController;

    public float GetHeroHorizontalValue()
    {
        return heroInputController.HorizontalValue;
    }

}
