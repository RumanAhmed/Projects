import java.util.Scanner;
/* This program asks the user to input a weight in pounds,
   converts it to kilos, and outputs the result */
class convertWeight
{
   public static void main (String [] args)
   {  
		Scanner input = new Scanner(System.in);	    
		double pounds, kilos;

   	System.out.print("Please input a weight in pounds ");
      	pounds = input.nextDouble();

		kilos = pounds / 2.2;
      	
		System.out.print(pounds + " pounds = " + 
				     kilos + " kilos.");
   }
}
