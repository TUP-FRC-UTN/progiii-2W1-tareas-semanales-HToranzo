
package comercio;


public class ClientePreferencial extends Cliente {
    private double saldo;
    private double limite;
    private String domicilio;

    public ClientePreferencial(double saldo, double limite, String domicilio, int numero, String nombre, int telefono) {
        super(numero, nombre, telefono);
        this.saldo = saldo;
        this.limite = limite;
        this.domicilio = domicilio;
    }

    public double getSaldo() {
        return saldo;
    }

    public double getLimite() {
        return limite;
    }

    public String getDomicilio() {
        return domicilio;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }

    public void setLimite(double limite) {
        this.limite = limite;
    }

    public void setDomicilio(String domicilio) {
        this.domicilio = domicilio;
    }

    @Override
    public String toString() {
        return super. toString()+"ClientePreferencial{" + "saldo=" + saldo + ", limite=" + limite + ", domicilio=" + domicilio + '}';
    }

    
    
    
    
}
