import java.util.Scanner;
class Main {
    public static void main(String[] args) {
        
            // Fill your code here
            Scanner s=new Scanner(System.in);
            int n=s.nextInt();
            for(int i=1;i<=n;i++)
            {
                for (int j=n;j>=i;j--)
                {
                    System.out.print(j+" ");
                }
                System.out.println();
            }
        
     }
}
