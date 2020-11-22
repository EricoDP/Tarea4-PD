package patronfactory;

public class ConectarEmpty implements Conectar{

	@Override
	public void conectar() {
		System.out.println("No se especifico motor de base de datos");		
	}

	@Override
	public void desconectar() {
		System.out.println("No se especifico motor de base de datos");			
	}
}
