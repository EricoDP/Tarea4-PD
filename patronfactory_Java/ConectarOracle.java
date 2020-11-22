package patronfactory;

public class ConectarOracle implements Conectar{

	private String host;
	private String port;
	private String user;
	private String pass;
	
	public ConectarOracle(String host, String port, String user, String pass) {
		this.host = host;
		this.port = port;
		this.user = user;
		this.pass = pass;
	}
	
	@Override
	public void conectar() {
		System.out.println("Se conecto a Oracle");		
	}

	@Override
	public void desconectar() {
		System.out.println("Se desconecto de Oracle");			
	}
}
