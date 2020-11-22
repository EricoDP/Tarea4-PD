package Main;

public class Marco {
	
	private Metodo metodo;
	 
	public Marco(Metodo metodo) {
		this.metodo = metodo;
	}
	
	public void Efectuar() {
		this.metodo.Detectar();
	}
}
