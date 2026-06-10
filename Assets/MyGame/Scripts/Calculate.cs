using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

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
    
    private void Start()
    {
        //Setzt den Ersten Gues
        guess = (guesMin + guesMax) / 2;
        //Setzt den Text auf Guess und Nachricht
        Guestxt.text = "is your Number " + guess + "?";
    }
    private void Update()
    {
        //wenn es nicht Correct ist wird der Gues text Aktualisiert
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
        //setzt die Schrift Größe auf 30 setzt den Text auf den Win text, Blendet die Buttons aus
        cangues = false;
        Guestxt.fontSize = 30;
        Guestxt.text = "I guessed your Number " + guesMin + "!";
        Button1.SetActive(false);
        Button2.SetActive(false);
        TimerForRestart();
    }
    private IEnumerator TimerForRestart()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
