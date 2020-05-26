
package automotor;

public class Automotor {

    public static void main(String[] args) {
        
        Auto a = new Auto("Honda",2010);
        
        a.setPrecio(750);
        a.setKilometraje(150000);
        
        Auto b = a;
        b.setPrecio(14000);
        b.setKilometraje(10);
        
        System.out.println(a);
        System.out.println(b);
    }
    
}
