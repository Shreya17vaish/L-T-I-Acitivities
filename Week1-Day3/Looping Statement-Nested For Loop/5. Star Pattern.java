import java.util.*;
import java.io.*;

class Main{
	public static void main(String[] args) throws Exception{ 

//		Fill your code
     Scanner s=new Scanner(System.in);
	 int n=s.nextInt();
	 for(int i=1;i<=n;i++)
	 {
		 for(int j=1;j<=i;j++)
		 {
			 System.out.print("*");
		 }
		 System.out.println();
	 }

	}
}

