import java.util.Scanner;
class Main {
    public static void main(String[] args) {
         // Fill your code here
         int m=1;
        Scanner s =new Scanner (System.in);
        int n=s.nextInt();
        //System.out.println(n);
        for (int i=1;i<=n;i++)
        {
            m=m*i;
        }
        System.out.println(m);
     }
}
