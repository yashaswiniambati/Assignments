using UnityEngine;
using UnityEngine. UI;
using System;

public class TicTacToeCode : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Boolean checker;
       int plusone;

       public Text Button0 = null;
       public Text Button1 = null;
       public Text Button2 = null;
       public Text Button3 = null;
       public Text Button4 = null;
       public Text Button5 = null;
       public Text Button6 = null;
       public Text Button7 = null;
       public Text Button8 = null;

public Text Reset = null;
public Text NewGame = null;
public Text msgFeedback = null;

public Text PlayerX = null;
public Text PlayerO = null;

public void score()
    {
        if (Button0.text == "X" && Button1.text == "X" && Button2.text == "X") 
        {
          Button0.color = Color.cyan;
          Button1.color = Color.cyan;
          Button2.color = Color.cyan;
          msgFeedback.text = "The Winner is Player X";
          plusone = int.Parse(PlayerX.text);
          PlayerX.text = Convert.ToString(plusone + 1)
        }    

        if (Button0.text == "X" && Button3.text == "X" && Button6.text == "X") 
        {
          Button0.color = Color.yellow;
          Button3.color = Color.yellow;
          Button6.color = Color.yellow;
          msgFeedback.text = "The Winner is Player X";
          plusone = int.Parse(PlayerX.text);
          PlayerX.text = Convert.ToString(plusone + 1)
        } 

        if (Button0.text == "X" && Button4.text == "X" && Button8.text == "X") 
        {
          Button0.color = Color.cyan;
          Button4.color = Color.cyan;
          Button8.color = Color.cyan;
          msgFeedback.text = "The Winner is Player X";
          plusone = int.Parse(PlayerX.text);
          PlayerX.text = Convert.ToString(plusone + 1)
        }    

        if (Button2.text == "X" && Button4.text == "X" && Button6.text == "X") 
        {
          Button2.color = Color.yellow;
          Button4.color = Color.yellow;
          Button6.color = Color.yellow;
          msgFeedback.text = "The Winner is Player X";
          plusone = int.Parse(PlayerX.text);
          PlayerX.text = Convert.ToString(plusone + 1)
        } 

        if (Button3.text == "X" && Button4.text == "X" && Button5.text == "X") 
        {
          Button3.color = Color.cyan;
          Button4.color = Color.cyan;
          Button5.color = Color.cyan;
          msgFeedback.text = "The Winner is Player X";
          plusone = int.Parse(PlayerX.text);
          PlayerX.text = Convert.ToString(plusone + 1)
        }    

        if (Button6.text == "X" && Button7.text == "X" && Button8.text == "X") 
        {
          Button6.color = Color.yellow;
          Button7.color = Color.yellow;
          Button8.color = Color.yellow;
          msgFeedback.text = "The Winner is Player X";
          plusone = int.Parse(PlayerX.text);
          PlayerX.text = Convert.ToString(plusone + 1)
        } 
        
        if (Button2.text == "X" && Button5.text == "X" && Button8.text == "X") 
        {
          Button2.color = Color.cyan;
          Button5.color = Color.cyan;
          Button8.color = Color.cyan;
          msgFeedback.text = "The Winner is Player X";
          plusone = int.Parse(PlayerX.text);
          PlayerX.text = Convert.ToString(plusone + 1)
        }    

        if (Button1.text == "X" && Button4.text == "X" && Button7.text == "X") 
        {
          Button1.color = Color.yellow;
          Button4.color = Color.yellow;
          Button7.color = Color.yellow;
          msgFeedback.text = "The Winner is Player X";
          plusone = int.Parse(PlayerX.text);
          PlayerX.text = Convert.ToString(plusone + 1)
        } 

        //============Player O===============

        if (Button0.text == “O” && Button1.text == “O” && Button2.text == “O”) 
        {
          Button0.color = Color.cyan;
          Button1.color = Color.cyan;
          Button2.color = Color.cyan;
          msgFeedback.text = "The Winner is Player O";
          plusone = int.Parse(PlayerO.text);
          PlayerO.text = Convert.ToString(plusone + 1)
        }    

        if (Button0.text == “O” && Button3.text == “O” && Button6.text == “O”) 
        {
          Button0.color = Color.yellow;
          Button3.color = Color.yellow;
          Button6.color = Color.yellow;
          msgFeedback.text = "The Winner is Player O";
          plusone = int.Parse(PlayerO.text);
          PlayerO.text = Convert.ToString(plusone + 1)
        } 

        if (Button0.text == “O” && Button4.text == “O” && Button8.text == “O”) 
        {
          Button0.color = Color.cyan;
          Button4.color = Color.cyan;
          Button8.color = Color.cyan;
          msgFeedback.text = "The Winner is Player O";
          plusone = int.Parse(PlayerO.text);
          PlayerO.text = Convert.ToString(plusone + 1)
        }    

        if (Button2.text == “O” && Button4.text == “O” && Button6.text == “O”) 
        {
          Button2.color = Color.yellow;
          Button4.color = Color.yellow;
          Button6.color = Color.yellow;
          msgFeedback.text = "The Winner is Player O";
          plusone = int.Parse(PlayerO.text);
          PlayerO.text = Convert.ToString(plusone + 1)
        } 

        if (Button3.text == “O” && Button4.text == “O” && Button5.text == “O”) 
        {
          Button3.color = Color.cyan;
          Button4.color = Color.cyan;
          Button5.color = Color.cyan;
          msgFeedback.text = "The Winner is Player O";
          plusone = int.Parse(PlayerO.text);
          PlayerO.text = Convert.ToString(plusone + 1)
        }    

        if (Button6.text == “O” && Button7.text == “O” && Button8.text == “O”) 
        {
          Button6.color = Color.yellow;
          Button7.color = Color.yellow;
          Button8.color = Color.yellow;
          msgFeedback.text = "The Winner is Player O";
          plusone = int.Parse(PlayerO.text);
          PlayerO.text = Convert.ToString(plusone + 1)
        } 
        
        if (Button2.text == “O” && Button5.text == “O” && Button8.text == “O”) 
        {
          Button2.color = Color.cyan;
          Button5.color = Color.cyan;
          Button8.color = Color.cyan;
          msgFeedback.text = "The Winner is Player O";
          plusone = int.Parse(PlayerO.text);
          PlayerO.text = Convert.ToString(plusone + 1)
        }    

        if (Button1.text == “O” && Button4.text == “O” && Button7.text == “O”) 
        {
          Button1.color = Color.yellow;
          Button4.color = Color.yellow;
          Button7.color = Color.yellow;
          msgFeedback.text = "The Winner is Player O";
          plusone = int.Parse(PlayerO.text);
          PlayerO.text = Convert.ToString(plusone + 1)
        } 
    // Update is called once per frame
    void Update()
    {
        
    }
}
