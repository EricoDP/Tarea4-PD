package patronfactory;

public class Main {

	public static void main(String[] args) {
		ConectarFactory factory = new ConectarFactory();
		
		Conectar c1 = factory.getConexion("Oracle");
		c1.conectar();
		c1.desconectar();
		
		Conectar c2 = factory.getConexion("Mysql");
		c2.conectar();
		c2.desconectar();
		
		Conectar c3 = factory.getConexion("Oracle");
		c3.conectar();
		c3.desconectar();
	}
}
