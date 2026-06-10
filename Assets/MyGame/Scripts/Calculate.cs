using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Calculate : MonoBehaviour
{
    public int guesMin;
    public int guesMax;
    public int guess;
    public GameObject Button1;
    public GameObject Button2;
    [SerializeField]
    private Text Guestxt;
    private bool cangues = true ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        guess = (guesMin + guesMax) / 2;
        Guestxt.text = "is your Number " + guess + "?";
    }

    // Update is called once per frame
    void Update()
    {
        if (cangues == true)
        {
            Guestxt.text = "is your Number " + guess + "?";
        }
        
    }
    public void guesHigher()
    {
        guesMin = guess +1;
        guess = (guesMin + guesMax) / 2;
    }
    public void guessLower()
    {
        guesMax = guess - 1;
        guess = (guesMin + guesMax) / 2;
    }
    public void CorrectGues()
    {
        cangues = false;
        Guestxt.fontSize = 30;
        Guestxt.text = "I guesed your Number " + guesMin + "!";
        Button1.SetActive(false);
        Button2.SetActive(false);
    }
}
