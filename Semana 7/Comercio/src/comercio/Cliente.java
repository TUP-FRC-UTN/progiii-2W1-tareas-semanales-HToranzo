
package comercio;

public class Cliente {
    protected int numero;
    protected String nombre;
    protected int telefono;

    public Cliente(int numero, String nombre, int telefono) {
        this.numero = numero;
        this.nombre = nombre;
        this.telefono = telefono;
    }

    public int getNumero() {
        return numero;
    }

    public String getNombre() {
        return nombre;
    }

    public int getTelefono() {
        return telefono;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setTelefono(int telefono) {
        this.telefono = telefono;
    }

    @Override
    public String toString() {
        return "Cliente{" + "numero=" + numero + ", nombre=" + nombre + ", telefono=" + telefono + '}';
    }
    
    
}
