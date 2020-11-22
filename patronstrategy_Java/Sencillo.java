package Main;

public abstract class Sencillo implements Metodo{
	public void Detectar() {
		Comenzar();
		Saltar();
		Finalizar();
	}
	
	abstract void Comenzar();
	abstract void Saltar();
	abstract void Finalizar();
}
