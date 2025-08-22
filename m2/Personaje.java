package m2;
public class Personaje {
    private String nombre;
    private int defensa;
    private int poder;
    private int salud;

    public Personaje(String nombre, int defensa, int poder, int salud) {
        this.nombre = nombre;
        this.defensa = defensa;
        this.poder = poder;
        this.salud = salud;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getDefensa() {
        return defensa;
    }

    public void setDefensa(int defensa) {
        this.defensa = defensa;
    }

    public int getPoder() {
        return poder;
    }

    public void setPoder(int poder) {
        this.poder = poder;
    }

    public int getSalud() {
        return salud;
    }

    public void setSalud(int salud) {
        this.salud = salud;
    }
}
