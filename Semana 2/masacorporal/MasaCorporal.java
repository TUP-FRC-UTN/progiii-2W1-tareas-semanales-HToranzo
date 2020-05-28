
package masacorporal;

import java.util.Scanner;

public class MasaCorporal {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        System.out.print("Ingrese el nombre :");
        String nombre = sc.nextLine();
        System.out.print("Ingrese el apellido :");
        String apellido = sc.nextLine();
        System.out.print("Ingrese el peso :");
        double peso = sc.nextDouble();
        System.out.print("Ingrese la altura :");
        double altura = sc.nextDouble();
        
        Persona p = new Persona(nombre, apellido, peso, altura);
        
        System.out.println(p);
        System.out.println(p.IMC());
    }
    
}
