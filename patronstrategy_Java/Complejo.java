package Main;

public abstract class Complejo implements Metodo{
	public void Detectar() {
		Comenzar();
		Memoria();
		KeyLoggers();
		RootKis();
		Descomprimir();
		Finalizar();
	}
	
	abstract void Comenzar();
	abstract void Memoria();
	abstract void KeyLoggers();
	abstract void RootKis();
	abstract void Descomprimir();
	abstract void Finalizar();
}
