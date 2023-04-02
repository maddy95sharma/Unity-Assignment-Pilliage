using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCardManager : MonoBehaviour
{
    private static PlayerCardManager _instance;
    public static PlayerCardManager Instance {get { return _instance; } }
    CardType card1Type, card2Type, card3Type, card4Type;
    private Card card1, card2, card3, card4;

    [SerializeField]
    private bool _isCard1Played;
    public bool IsCard1Played{ get {return _isCard1Played; } }
    [SerializeField]
    private bool _isCard2Played;
    public bool IsCard2Played{ get {return _isCard2Played; } }
    [SerializeField]
    private bool _isCard3Played;
    public bool IsCard3Played{ get {return _isCard3Played; } }
    [SerializeField]
    private bool _isCard4Played;
    public bool IsCard4Played{ get {return _isCard4Played; } }


    public void OnCard1Played() {
        _isCard1Played = true;
        card1.gameObject.SetActive(false);
    }
    
    public void OnCard2Played() {
        _isCard2Played = true;
        card2.gameObject.SetActive(false);
    }
    
    public void OnCard3Played() {
        _isCard3Played = true;
        card3.gameObject.SetActive(false);
    }
    
    // public void OnCard4Played() {
    //     _isCard4Played = true;
    //     card4.gameObject.SetActive(false);
    // }
    
    void Awake()
    {
        if(_instance!=null)
            Destroy(gameObject);
        else
            _instance =this;
    }

}
