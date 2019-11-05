import java.util.Scanner;

/* this program adds 2 numbers together */

class subtract
{
	public static void main(String [] args)
	{
		Scanner input = new Scanner(System.in);
		int x, y, z;
		
		system.out.print("Enter first number")
		x = input.nextInt();
		
		System.out.print("Enter second number ");
		y = input.nextInt();
		
		system.out.print("Enter third number")
		z = input.nextInt();
		
		if (x>y)
			if (x>z)
				system.out.printIn("Largest is" + x)
			else
				system.out.printIn("Largest is" + z)
			else
				if (y>z)
					system.out.printIn("Largest is" + y)
				else
					system.out.printIn("Largest is" + z)
			
	}
}