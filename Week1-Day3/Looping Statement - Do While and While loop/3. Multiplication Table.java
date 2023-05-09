import java.util.Scanner;
class Main {
    public static void main(String[] args) {
        
            // Fill your code here
            Scanner s=new Scanner(System.in);
            System.out.println("Enter n");
            int n=s.nextInt();
            System.out.println("Enter m");
            int m=s.nextInt();
            System.out.println("The multiplication table of "+ n +" is");
            int i=1;
            while( i<=m)
            {
             
               int table= n*i;
               System.out.println(i+"*"+n+"="+table);
                i++;
            }
        
     }
}
