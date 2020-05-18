
package comercio;

public class Comercio {


    public static void main(String[] args) {
        Cliente c = new Cliente( 1,"Alejandro",123);
        
        Cliente cp = new ClientePreferencial(250,600,"San martin",2,"Hector",456);
        
        System.out.println(c.toString());
        System.out.println(cp.toString());
    }
    
}
