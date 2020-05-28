
package declararvariables;

import java.util.Scanner;

public class DeclararVariables {

    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        
        System.out.println("Ingresar el valor de A :");
        int a = entrada.nextInt();
        System.out.println("Ingresar el valor de B :");
        int b = entrada.nextInt();
        
        int suma = a+b;
        int resta = a-b;
        double division = (double)a/b;
        
        System.out.println("La suma es : " + suma);
        System.out.println("La resta es : " + resta);
        System.out.println("La division es : " + division);
         
    }
    
}
