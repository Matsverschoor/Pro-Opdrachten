using System;

//Mario erft nu de Classes/Functions van character
public class Star : Character
{

    public string Ultraspeed1 = "Mario is going";
    public string Ultraspeed2 = "mp/h.";


  //function override
 public void Invincible()
 {
   Console.WriteLine("Mario is now invincible, he can't take damage!");
 }




}