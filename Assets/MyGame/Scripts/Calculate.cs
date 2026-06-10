using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Calculate : MonoBehaviour
{
    public int guesMin;
    public int guesMax;
    public int guess;
    [SerializeField]
    private Text Guestxt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        guess = (guesMin + guesMax) / 2;
    }

    // Update is called once per frame
    void Update()
    {
        Guestxt.text = "is your Number " + guess + "?";
        
    }
    public void guesHigher()
    {
        guesMin = guess;
        guess = (guesMin + guesMax) / 2;
    }
}
