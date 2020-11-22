package patronfactory;

public class ConectarFactory {
	
	public Conectar getConexion(String motor) {
		if(motor == null) {
			return new ConectarEmpty();
		}
		if(motor.equalsIgnoreCase("Sql")) {
			return new ConectarSql("localhost","1433","postgres","123");
		}
		else if(motor.equalsIgnoreCase("Oracle")) {
			return new ConectarSql("localhost","1433","postgres","123");
		}
		
		return new ConectarEmpty();
	}
}
