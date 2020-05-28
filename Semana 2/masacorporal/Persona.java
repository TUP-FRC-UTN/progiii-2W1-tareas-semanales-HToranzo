
package masacorporal;

public class Persona {
    private String nombre;
    private String apellido;
    private double peso;
    private double altura;

    public Persona(String nombre, String apellido, double peso, double altura) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.peso = peso;
        this.altura = altura;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }

    public double getAltura() {
        return altura;
    }

    public void setAltura(double altura) {
        this.altura = altura;
    }

    @Override
    public String toString() {
        return "Persona{" + "nombre=" + nombre + ", apellido=" + apellido + ", peso=" + peso + ", altura=" + altura + '}';
    }
    
    public double IMC(){
        double IMC = peso/(altura*altura);
        return IMC;
    }
}
