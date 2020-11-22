package Main;

public class AntSen extends Sencillo {

	@Override
	void Comenzar() {
		System.out.println("Revision sencilla - Revision sencilla comenzada");
	}

	@Override
	void Saltar() {
		try {
			System.out.println("Revisando...");
			Thread.sleep(2500);
			System.out.println("No se pudo revisar archivos con extension .zip");
		}catch(InterruptedException e) {
			e.printStackTrace();
		}	
	}

	@Override
	void Finalizar() {
		System.out.println("Revision sencilla - Revision sencilla finalizada");		
	}

}